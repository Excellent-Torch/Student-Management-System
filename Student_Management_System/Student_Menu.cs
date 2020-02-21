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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Students f8 = new Students();
            f8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_log f5 = new Student_log();
            f5.Show();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Users\Excellent_Torch\Music\PlayLists\01-flo_rida_ft._t-pain-low.mp3");
            player.Play();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.Show();
            
        }
    }
}
