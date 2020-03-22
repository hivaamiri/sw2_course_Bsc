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
    public partial class insurereg : Form
    {
        public insurereg()
        {
            InitializeComponent();
        }
        read_write n = new read_write();
        

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                bool c = n.write("insert into insurance_Company values('" + namesazman.Text + "','" + darsadepardakhti.Text + "')");
                if (c)
                {
                    MessageBox.Show("ذخیره شد");
                }
                else
                {
                    MessageBox.Show("ذخیره نشد");
                }

                namesazman.Text = "";
                darsadepardakhti.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("ذخیره نشد");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            namesazman.Text = "";
            darsadepardakhti.Text = "";
            Close();
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }
    }
}
