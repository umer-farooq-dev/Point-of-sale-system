using Microsoft.VisualBasic.ApplicationServices;
using ReturnMedicalSystem.Forms;
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

namespace ReturnMedicalSystem
{
    public partial class Login : Form
    {
        //DB objdb = new DB();
        Dashboard d = new Dashboard();
        public Login()
        {
            InitializeComponent();

        }
        #region LoginMethod
        public void LoginUser()
        {
            try
            {
              SqlCommand cmd = new SqlCommand("sp_SignIn", DB.con);
               cmd.CommandType = CommandType.StoredProcedure;
                DB.con.Open();
                cmd.Parameters.AddWithValue("@u", txtUserName.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                SqlDataReader dataReader = cmd.ExecuteReader();    

                if (dataReader.Read())
                {

                    if (dataReader[5].Equals("Administrator"))
                    {

                        Dashboard Dash = new Dashboard();
                        this.Hide();
                        Dash.Lbl_User.Text = dataReader["UserType"].ToString();
                        //Dash.Lbl_UserName.Text = dataReader["UserName"].ToString();

                        Dash.ShowDialog();

                        this.Close();
                    }
                   

                }
                else if (txtUserName.Text.Trim() == string.Empty & txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Email And Password Fileds Empty", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtUserName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Username", "Username Blank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Password", "Password Blank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DB.con.Close();
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin" && txtPassword.Text == "admin")
            {
                d.Show();
            }
            else
            {
                MessageBox.Show("Please enter Corect Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
