using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace داروخانه
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        read_write rw = new read_write();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                Form3 nn = new Form3();
                nn.ShowDialog();
            }
            else
            {
                MessageBox.Show("نام کاربر یا رمز عبور اشتباه است");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
