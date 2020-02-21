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
    public partial class Admin_Reg : Form
    {
        public Admin_Reg()
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
                string user_name;
                string user_pwd;
                string user_email;
                int user_telephone;

                user_name = usernm.Text;
                user_pwd = userpw.Text;
                user_email = useremail.Text;
                user_telephone = int.Parse(usertele.Text);

                OleDbCommand cmd = new OleDbCommand("INSERT INTO admin_tbl(user_nm,user_pw,user_email,user_tele) VALUES('" + user_name + "','" + user_pwd + "','" + user_email + "','" + user_telephone + "')", connection);
                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("You Have Successfully Signed In", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !!" + ex);
            }
            finally
            {
                connection.Close();
                this.Hide();
                login_win f1 = new login_win();
                f1.Show();
            }
        }
        public void clearData() {
            usernm.Text = "";
            userpw.Text = "";
            useremail.Text = "";
            usertele.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_win f1 = new login_win();
            f1.Show();
        }

        private void usertele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
