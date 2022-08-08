using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnMedicalSystem.Clasess
{
    class Updation
    {
        public void updateproduct(int id, string name,string batch, string qty, string pin, string pout, string dis, string category, string barcode,string location)
        {
            //product update opration
            try
            {
                SqlCommand cmd = new SqlCommand("stp_updateProduct", DB.con);
              
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@priceIn", pin);
                cmd.Parameters.AddWithValue("@quantity", qty);
                cmd.Parameters.AddWithValue("@discount", dis);
                cmd.Parameters.AddWithValue("@batch", batch);
                cmd.Parameters.AddWithValue("@piceOut", pout);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@location", location);
                DB.con.Open();
                cmd.ExecuteNonQuery();
                DB.con.Close();
                MessageBox.Show("Data Updated  Successfully", "Updated");

            }
            catch (Exception)
            {
                MessageBox.Show("Data Not Updated ", "Not Save");



            }
        }
    }
}



