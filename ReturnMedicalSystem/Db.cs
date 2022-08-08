using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ReturnMedicalSystem
{
    public class DB
    {
        // data base conectivity
        public static string Query = "server=.;database=PosSystem;uid=sa;pwd=123;";
        public static SqlConnection con = new SqlConnection(Query);

        public SqlDataAdapter sda;
        public DataTable dt;
        public SqlCommand cmd;
        public SqlDataReader dr;
        //public static string c;
        //private string b;

         public void Addbarcode()
        {

        }
        public void CheckCon(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

            }
        }
        public void AutoId(string StoreProcedure, Label LblID)
        {


            try
            {
                cmd = new SqlCommand(StoreProcedure, con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    LblID.Text = dr[0].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        public DataTable GetTable(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetTable(string query, SqlParameter[] ParamValues)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            sda = new SqlDataAdapter();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddRange(ParamValues);
            cmd.ExecuteNonQuery();
            sda.SelectCommand = cmd;
            dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetTable(string query, SqlParameter[] ParamValues, CommandType cmdType)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            sda = new SqlDataAdapter();
            cmd = new SqlCommand(query, con)
            {
                CommandType = cmdType
            };
            cmd.Parameters.AddRange(ParamValues);
            cmd.ExecuteNonQuery();
            sda.SelectCommand = cmd;
            dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Executequery(string query)
        {
            int Rowcount;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd = new SqlCommand(query, con);
            Rowcount = cmd.ExecuteNonQuery();
            con.Close();
            if (Rowcount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool Executequery(string query, SqlParameter[] ParamValues)
        {
            int Rowcount;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddRange(ParamValues);
            Rowcount = cmd.ExecuteNonQuery();
            con.Close();
            if (Rowcount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Executequery(string query, SqlParameter[] ParamValues, CommandType cmdType)
        {
            int Rowcount;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddRange(ParamValues);
            cmd.CommandType = cmdType;
            Rowcount = cmd.ExecuteNonQuery();
            con.Close();
            if (Rowcount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

       
        }
       

            }
        

       

            


        


        

