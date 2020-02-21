using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Student_Management_System
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            StudentDataGridView.DataSource = GetStudentList();
            this.StudentDataGridView.Columns["stpw"].Visible = false;
            this.StudentDataGridView.Columns["NIC"].Visible = false;
        }
        private DataTable GetStudentList()
        {
            DataTable dtStudents = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["stdb"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM student_tbl",con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtStudents.Load(reader);
                }
            }

                return dtStudents;

        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = StudentDataGridView.RowCount;
            count = count - 1;
            label1.Text = "No : " + count;
        }
    }
}
