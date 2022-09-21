using ReturnMedicalSystem.Clasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnMedicalSystem.Forms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        private int xPos = 0;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        Selection s = new Selection();
        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

            s.showproduct(DataGridView_Product, DGv_Id, DGv_name,DGv_Batch,DGv_DS, DGv_QTY, DGv_PIN, DGv_POUT, DGv_Category, DGv_Barcode,DGv_location);
            timer1.Start();
        }

        private void txt_searchProduct_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchProduct.Text != "")
            {
                s.showproduct(DataGridView_Product, DGv_Id, DGv_name,DGv_Batch, DGv_DS, DGv_QTY, DGv_PIN, DGv_POUT, DGv_Category, DGv_Barcode,DGv_location, txt_searchProduct.Text);
            }
            else
            {
                s.showproduct(DataGridView_Product, DGv_Id, DGv_name,DGv_Batch, DGv_DS, DGv_QTY, DGv_PIN, DGv_POUT, DGv_Category, DGv_Barcode,DGv_location);
            }
        }

        private void Btn_EmptyProduct_Click(object sender, EventArgs e)
        {
            DB.con.Open();
            SqlCommand cmd = DB.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Product where Quantity=0";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataGridView_Product.DataSource = dt;
            DB.con.Close();
        }

        private void DataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_RequiredProduct_Click(object sender, EventArgs e)
        {
            DB.con.Open();
            SqlCommand cmd = DB.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Product where Quantity <10";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataGridView_Product.DataSource = dt;
            DB.con.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xPos)
            {
                //repeat marquee
                this.lbl_Marquee.Location = new Point(462, 75);
                xPos = 0;
            }
            else
            {
                this.lbl_Marquee.Location = new Point(xPos, 75);
                xPos++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
