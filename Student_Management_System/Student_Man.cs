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
    public partial class Student_Man : Form
    {
        public Student_Man()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excellent_Torch\Documents\studentdb.accdb; Persist Security Info=False;");


        private void Form9_Load(object sender, EventArgs e)
        {
            StudentData.DataSource = GetStudentList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("delete * from student_tbl where StudentID='" + row_no.Text + "' ", connection);
                OleDbDataReader r;
                cmd.ExecuteNonQuery();
     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Searching " + ex);

            }
            finally
            {
                StudentData.Update();
                StudentData.Refresh();
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void StudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
