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
    public partial class Student_log : Form
    {
        public Student_log()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excellent_Torch\Documents\studentdb.accdb; Persist Security Info=False;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("select * from student_tbl where StudentID='" + st_id.Text + "' and stpw='" + st_pw.Text + "' ", connection);
                OleDbDataReader r;
                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    if (r[0].ToString() == st_id.Text && r[6].ToString() == st_pw.Text)
                    {
                        this.Hide();
                        Form7 f7 = new Form7();
                        f7.Show();
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Excellent_Torch\Documents\login.wav");
                        player.Play();
                    }
                    if (r[0].ToString() != st_id.Text || r[6].ToString() != st_pw.Text)
                    {
                        MessageBox.Show("Wrong ID Or Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_win f1 = new login_win();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void st_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
