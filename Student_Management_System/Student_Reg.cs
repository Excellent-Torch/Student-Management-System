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
using System.Configuration;

namespace Student_Management_System
{
    public partial class student_reg : Form
    {
        public student_reg()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excellent_Torch\Documents\studentdb.accdb; Persist Security Info=False;");

        private void student_reg_Load(object sender, EventArgs e)
        {
            StudentRegView.DataSource = GetStudentList();
            this.StudentRegView.Columns["Course"].Visible = false;
            this.StudentRegView.Columns["Telephone_No"].Visible = false;
            this.StudentRegView.Columns["Gender"].Visible = false;
            this.StudentRegView.Columns["NIC"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string id;
                string fna;
                string lna;
                string pw;
                int nic;
                int tele;
                string gen;
                string course;

                id = st_id.Text;
                fna = first_name.Text;
                lna = last_name.Text;
                nic = int.Parse(nic_no.Text);
                tele = int.Parse(tele_no.Text);
                pw = st_pw.Text;
                course = course_list.Text;

                if (rb_female.Checked)
                {
                    gen = "Female";
                }
                else
                {
                    gen = "Male";
                }

                OleDbCommand cmd = new OleDbCommand("INSERT INTO student_tbl(StudentID,FirstName,LastName,NIC,Gender,Telephone_No,stpw,Course) VALUES('" + id + "','" + fna + "','" + lna + "','" + nic + "','" + gen + "','" + tele + "','" + pw + "','" + course + "')", connection);
                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("You Have Successfully Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error !!" + ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public void clearData()
        {
            st_id.Text = "";
            first_name.Text = "";
            last_name.Text = "";
            nic_no.Text = "";
            tele_no.Text = "";
            st_pw.Text = "";
            course_list.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("select * from student_tbl where StudentID='" + student_search.Text + "' ", connection);
                OleDbDataReader r;
                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    st_id.Text = r[0].ToString();
                    first_name.Text = r[1].ToString();
                    last_name.Text = r[2].ToString();
                    nic_no.Text = r[3].ToString();
                    tele_no.Text = r[5].ToString();
                    st_pw.Text = r[6].ToString();
                    course_list.Text = r[7].ToString();

                    if (r[4].ToString() == "male")
                    {
                        rb_male.Checked = true;
                    }
                    else
                    {
                        rb_female.Checked = true;
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
        private DataTable GetStudentList()
        {
            DataTable dtStudents = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["stdb"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM student_tbl", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtStudents.Load(reader);
                }
            }

            return dtStudents;

        }

        private void st_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tele_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nic_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void student_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
  }
   
