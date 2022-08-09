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
    public partial class Suppllers : Form
    {
        public Suppllers()
        {
            InitializeComponent();
        }
        Selection s = new Selection();
        SqlCommand cmd;
        DataSet ds = new DataSet();

        int productid;

        private void btn_supSav_Click(object sender, EventArgs e)
        {
            //This operation for eror message
            if (txt_supN.Text == "") { lbl_erorname.Visible = true; } else { lbl_erorname.Visible = false; }
            if (txt_supP.Text == "") { lbl_errorphone.Visible = true; } else { lbl_errorphone.Visible = false; }
            if (txt_supAd.Text == "") { lbl_erroraddress.Visible = true; } else { lbl_erroraddress.Visible = false; }
            if (txt_supRe.Text == "") { lbl_errorremarks.Visible = true; } else { lbl_errorremarks.Visible = false; }
            if (lbl_erorname.Visible || lbl_errorphone.Visible || lbl_erroraddress.Visible || lbl_errorremarks.Visible)
            {
                MessageBox.Show("Required field is not fill", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //insert the product
                Insertion i = new Insertion();
                i.insertsupplier(txt_supN.Text, txt_supP.Text, txt_supAd.Text, txt_supRe.Text);
                s.showSupplier(DataGridView_Supplier, DGv_Id, DGv_name, DGv_PH, DGv_ADD, DGv_RE);
                txt_supN.Clear();
                txt_supP.Clear();
                txt_supAd.Clear();
                txt_supRe.Clear();
            }
        }

        private void Suppllers_Load(object sender, EventArgs e)
        {

        }

        private void btn_supUpdate_Click(object sender, EventArgs e)
        {
            //update the product
            {
                DialogResult obj1 = new DialogResult();
                obj1 = MessageBox.Show("Are You Sure You Want To Update Product", "Updated", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (obj1 == DialogResult.Yes)

                {
                    Updation up = new Updation();
                    up.updatesupplier(productid, txt_supN.Text, txt_supP.Text, txt_supAd.Text, txt_supRe.Text);
                    s.showSupplier(DataGridView_Supplier,DGv_Id, DGv_name, DGv_PH, DGv_ADD, DGv_RE);
                    txt_supN.Clear();
                    txt_supP.Clear();
                    txt_supAd.Clear();
                    txt_supRe.Clear();


                }



            }
        }

        private void btn_supdel_Click(object sender, EventArgs e)
        {
            DialogResult obj1 = new DialogResult();
            obj1 = MessageBox.Show("Are You Sure You Want To Delete Product", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (obj1 == DialogResult.Yes)
            {
                Deletion d = new Deletion();
                d.deletion(productid, "stp_deleteSupplier", "@id");
                s.showSupplier(DataGridView_Supplier, DGv_Id,DGv_name, DGv_PH, DGv_ADD, DGv_RE);
                txt_supN.Clear();
                txt_supP.Clear();
                txt_supAd.Clear();
                txt_supRe.Clear();
            }

        }

        private void DataGridView_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DataGridView_Supplier.Rows[e.RowIndex];
                productid = Convert.ToInt32(row.Cells["DGv_Id"].Value.ToString());
                txt_supN.Text = row.Cells["DGv_name"].Value.ToString();
                txt_supP.Text = row.Cells["DGv_PH"].Value.ToString();
                txt_supAd.Text = row.Cells["DGv_ADD"].Value.ToString();
                txt_supRe.Text = row.Cells["DGv_RE"].Value.ToString();
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            s.showSupplier(DataGridView_Supplier, DGv_Id, DGv_name, DGv_PH, DGv_ADD, DGv_RE);
        }

        private void btn_supRe_Click(object sender, EventArgs e)
        {
            txt_supN.Clear();
            txt_supP.Clear();
            txt_supAd.Clear();
            txt_supRe.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Close();
        }
    }
}
