using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_reg f3 = new student_reg();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login_win f1 = new login_win();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Excellent_Torch\Documents\logout.wav");
            player.Play();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_reg f3 = new student_reg();
            f3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Man f9 = new Student_Man();
            f9.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
