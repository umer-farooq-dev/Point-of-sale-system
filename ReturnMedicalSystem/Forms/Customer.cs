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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        Selection s = new Selection();
        SqlCommand cmd;
        DataSet ds = new DataSet();

        int productid;
        private void btn_cusSav_Click(object sender, EventArgs e)
        {
            //This operation for eror message
            if (txt_cusN.Text == "") { lbl_erorname.Visible = true; } else { lbl_erorname.Visible = false; }
            if (txt_cusP.Text == "") { lbl_errorphone.Visible = true; } else { lbl_errorphone.Visible = false; }
            if (txt_cusAd.Text == "") { lbl_erroraddress.Visible = true; } else { lbl_erroraddress.Visible = false; }
            if (lbl_erorname.Visible || lbl_errorphone.Visible || lbl_erroraddress.Visible)
            {
                MessageBox.Show("Required field is not fill", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //insert the product
                Insertion i = new Insertion();
                i.insertcustomer(txt_cusN.Text, txt_cusP.Text, txt_cusAd.Text);
                s.showCustomer(DataGridView_Customer, DGv_Id, DGv_name, DGv_PH, DGv_ADD);
                txt_cusN.Clear();
                txt_cusP.Clear();
                txt_cusAd.Clear();
            }
        }

        private void btn_cusUpdate_Click(object sender, EventArgs e)
        {
            {
                DialogResult obj1 = new DialogResult();
                obj1 = MessageBox.Show("Are You Sure You Want To Update Product", "Updated", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (obj1 == DialogResult.Yes)

                {
                    Updation up = new Updation();
                    up.updatecustomer(productid, txt_cusN.Text, txt_cusP.Text, txt_cusAd.Text);
                    s.showCustomer(DataGridView_Customer, DGv_Id, DGv_name, DGv_PH, DGv_ADD);
                    txt_cusN.Clear();
                    txt_cusP.Clear();
                    txt_cusAd.Clear();


                }

            }
        }

        private void btn_cusdel_Click(object sender, EventArgs e)
        {
            DialogResult obj1 = new DialogResult();
            obj1 = MessageBox.Show("Are You Sure You Want To Delete Product", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (obj1 == DialogResult.Yes)
            {
                Deletion d = new Deletion();
                d.deleteCustomer(productid, "stp_deletecustomer", "@id");
                s.showCustomer(DataGridView_Customer, DGv_Id, DGv_name, DGv_PH, DGv_ADD);
                txt_cusN.Clear();
                txt_cusP.Clear();
                txt_cusAd.Clear();
            }
        }

        private void DataGridView_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DataGridView_Customer.Rows[e.RowIndex];
                productid = Convert.ToInt32(row.Cells["DGv_Id"].Value.ToString());
                txt_cusN.Text = row.Cells["DGv_name"].Value.ToString();
                txt_cusP.Text = row.Cells["DGv_PH"].Value.ToString();
                txt_cusAd.Text = row.Cells["DGv_ADD"].Value.ToString();
            
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            s.showCustomer(DataGridView_Customer, DGv_Id, DGv_name, DGv_PH, DGv_ADD);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Close();
        }
    }
}
