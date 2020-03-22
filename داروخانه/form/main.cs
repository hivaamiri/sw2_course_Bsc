using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace داروخانه
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 n = new Form2();
            n.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insurereg n = new insurereg();
            n.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userreg n = new userreg();
            n.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drugreg n = new drugreg();
            n.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patreg n = new patreg();
            n.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
