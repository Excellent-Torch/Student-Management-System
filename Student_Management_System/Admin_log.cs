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
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.Show();
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Excellent_Torch\Documents\login.wav");
                        player.Play();
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
            Admin_Reg f6 = new Admin_Reg();
            f6.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Student_log f5 = new Student_log();
            f5.Show();
        }

        private void login_win_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AboutBox ab1 = new AboutBox();
            ab1.Show();
        }
    }
}
