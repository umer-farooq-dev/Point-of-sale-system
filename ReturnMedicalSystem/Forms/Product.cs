using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ReturnMedicalSystem.Clasess;

namespace ReturnMedicalSystem.Forms
{
    public partial class Product : Form
    {


        public Product()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Return;Integrated Security=True");
        Selection s = new Selection();
        SqlCommand cmd;
        DataSet ds = new DataSet();

        int productid;
        private void button1_Click(object sender, EventArgs e)
        {
            //Dashboard ds = new Dashboard();
            //ds.Show();
            //this.Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            //s.showproduct(DataGridView_Product, DGv_Id, DGv_name, DGv_Batch, DGv_QTY, DGv_PIN, DGv_POUT, DGv_DS, DGv_Expire, DGv_Barcode,DGv_location);
        }

        private void DataGridView_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GetProductRecord();
        }

        public void GetProductRecord()
        {

            //SqlCommand cmd = new SqlCommand("Select * from tbl_Product",con);
            //DataTable dt = new DataTable();
            //con.Open();

            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();

            //DataGridView_Product.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Close();
        }
        //int row=0;
        private void button2_Click(object sender, EventArgs e)
        {

            //This operation for eror message
            if (text_Name.Text == "") { lbl_erorname.Visible = true; } else { lbl_erorname.Visible = false; }
            if (text_Batch.Text == "") { label12.Visible = true; } else { label12.Visible = false; }
            if (text_QTY.Text == "") { lbl_erorQTY.Visible = true; } else { lbl_erorQTY.Visible = false; }
            if (text_PIN.Text == "") { lbl_erorPIN.Visible = true; } else { lbl_erorPIN.Visible = false; }
            if (text_POUT.Text == "") { lbl_erorPOUT.Visible = true; } else { lbl_erorPOUT.Visible = false; }
            if (text_DIS.Text == "") { lbl_erorDiscount.Visible = true; } else { lbl_erorDiscount.Visible = false; }
            if (text_Barcode.Text == "") { lbl_erorBarcode.Visible = true; } else { lbl_erorBarcode.Visible = false; }
            if (lbl_erorname.Visible || label12.Visible || lbl_erorQTY.Visible || lbl_erorPIN.Visible || lbl_erorPOUT.Visible || lbl_erorDiscount.Visible || lbl_erorBarcode.Visible)
            {
                MessageBox.Show("Required field is not fill", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //insert the product
                Insertion i = new Insertion();
                i.insertproduct(text_Name.Text, text_PIN.Text, text_QTY.Text, text_DIS.Text, text_Batch.Text,text_POUT.Text, categoryBox.Text, text_Barcode.Text,text_Location.Text);
                s.showproduct(DataGridView_Product, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch,DGv_POUT,DGv_category, DGv_Barcode,DGv_location);
                text_Name.Clear();
                text_Batch.Clear();
                text_QTY.Clear();
                text_PIN.Clear();
                text_POUT.Clear();
                text_DIS.Clear();
                text_Location.Clear();

             




            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //update the product
            {
                DialogResult obj1 = new DialogResult();
                obj1 = MessageBox.Show("Are You Sure You Want To Update Product", "Updated", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (obj1 == DialogResult.Yes)

                {
                    Updation up = new Updation();
                    up.updateproduct(productid, text_Name.Text, text_PIN.Text, text_QTY.Text, text_DIS.Text, text_Batch.Text, text_POUT.Text, categoryBox.Text, text_Barcode.Text, text_Location.Text);
                    s.showproduct(DataGridView_Product, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch, DGv_POUT, DGv_category, DGv_Barcode, DGv_location);
                    text_Batch.Clear();
                    text_QTY.Clear();
                    text_PIN.Clear();
                    text_POUT.Clear();
                    text_DIS.Clear();
                    text_Location.Clear();


                }



            }
        }

        private void DataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //View new product in data grid view
            
       
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            DialogResult obj1 = new DialogResult();
            obj1 = MessageBox.Show("Are You Sure You Want To Delete Product", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (obj1 == DialogResult.Yes)
            {
                Deletion d = new Deletion();
                d.deletion(productid, "stp_deleteProduct", "@id");
                s.showproduct(DataGridView_Product, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch, DGv_POUT, DGv_category, DGv_Barcode, DGv_location);
                text_Name.Clear();
                text_Batch.Clear();
                text_QTY.Clear();
                text_PIN.Clear();
                text_POUT.Clear();
                text_DIS.Clear();
                text_Barcode.Clear();
                text_Location.Clear();
            }


        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
             if (txt_search.Text != "")
            {
                s.showproduct(DataGridView_Product, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch, DGv_POUT, DGv_category, DGv_Barcode, DGv_location, txt_search.Text);
            }
            else
            {
                s.showproduct(DataGridView_Product, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch, DGv_POUT, DGv_category, DGv_Barcode, DGv_location);
            }
        }

        private void DataGridView_Product_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DataGridView_Product.Rows[e.RowIndex];
                productid = Convert.ToInt32(row.Cells["DGv_Id"].Value.ToString());
                text_Name.Text = row.Cells["DGv_name"].Value.ToString();
                text_Batch.Text = row.Cells["DGv_Batch"].Value.ToString();
                text_QTY.Text = row.Cells["DGv_QTY"].Value.ToString();
                text_PIN.Text = row.Cells["DGv_PIN"].Value.ToString();
                text_POUT.Text = row.Cells["DGv_POUT"].Value.ToString();
                text_DIS.Text = row.Cells["DGv_DS"].Value.ToString();
                categoryBox.Text = row.Cells["DGv_category"].Value.ToString();
                text_Barcode.Text = row.Cells["DGv_Barcode"].Value.ToString();
                text_Location.Text = row.Cells["DGv_location"].Value.ToString();
            }
        }

        private void text_POUT_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_erorBarcode_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_Product_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AddBarcode_Click(object sender, EventArgs e)
        {
            string num = "0123456789";
            int len = num.Length;
            string otp = string.Empty;
            int otpDigit = 8;
            string finalDigit;
            int getIndex;
            for(int i=0; i < otpDigit; i++)
            {
                do
                {
                    getIndex = new Random().Next(0, len);
                    finalDigit = num.ToCharArray()[getIndex].ToString();
                } while (otp.IndexOf(finalDigit) !=-1);
                otp += finalDigit;
            }
            text_Barcode.Text = otp;
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            s.showproduct(DataGridView_Product, DGv_Id, DGv_name, DGv_PIN, DGv_QTY, DGv_DS, DGv_Batch,DGv_POUT, DGv_category, DGv_Barcode, DGv_location);
        }
    }
    }

