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
    class Deletion
    {
        public void deletion(object id, string proc, string parm)
        {
            //product delete opration
            try
            {
                SqlCommand cmd = new SqlCommand(proc, DB.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parm, id);
                DB.con.Open();
                cmd.ExecuteNonQuery();
                DB.con.Close();
                MessageBox.Show("Delate Data  Successfully", "Deleted");

            }
            catch (Exception)
            {
                DB.con.Close();
                MessageBox.Show("Data Not Deleted ", "Not Deleted");



            }
        }


        public void deleteSupplier(object id, string proc, string parm)
        {
            //product delete opration
            try
            {
                SqlCommand cmd = new SqlCommand(proc, DB.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parm, id);
                DB.con.Open();
                cmd.ExecuteNonQuery();
                DB.con.Close();
                MessageBox.Show("Delate Data  Successfully", "Deleted");

            }
            catch (Exception)
            {
                DB.con.Close();
                MessageBox.Show("Data Not Deleted ", "Not Deleted");



            }



        }


        public void deleteCustomer(object id, string proc, string parm)
        {
            //product delete opration
            try
            {
                SqlCommand cmd = new SqlCommand(proc, DB.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parm, id);
                DB.con.Open();
                cmd.ExecuteNonQuery();
                DB.con.Close();
                MessageBox.Show("Delate Data  Successfully", "Deleted");

            }
            catch (Exception)
            {
                DB.con.Close();
                MessageBox.Show("Data Not Deleted ", "Not Deleted");



            }



        }
    }
}
