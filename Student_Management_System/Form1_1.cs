using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Student_Management_System
{
    public partial class login_win : Form
    {
        public login_win()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excellent_Torch\Documents\studentdb.accdb; Persist Security Info=False;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("select * from admin_tbl where user_nm='" + user_nm.Text +"' and user_pw='" + pwd.Text + "' ", connection);
                OleDbDataReader r;
                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    if (r[0].ToString() == user_nm.Text && r[1].ToString() == pwd.Text)
                    {
                        MessageBox.Show("You Have Successfully Logged In", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Searching " + ex);

            }
            finally
            {
                connection.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void f1_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void user_nm_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_acc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();

        }
    }
}
