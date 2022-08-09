using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ReturnMedicalSystem.Forms
{
    public partial class Dashboard : Form
    {
        public object Btn_SideDashUser { get; internal set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_User_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_UserName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //logout button operation
            DialogResult obj1=new DialogResult();

            Login obj = new Login();
            obj1 = MessageBox.Show("Are You Sure You Want To Logout", "Logout", MessageBoxButtons.YesNo,MessageBoxIcon.Warning); 
                

                

            if (obj1==DialogResult.Yes)
                
            {
               
                this.Hide();

                obj.ShowDialog();

                this.Close();

            }
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductsForm ps = new ProductsForm();
            ps.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bills b = new Bills();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Customer cu = new Customer();
            cu.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Suppllers sp = new Suppllers();
            sp.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Suppllers sp = new Suppllers();
            sp.Show();
        }
    }
}
