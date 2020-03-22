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
    public partial class userreg : Form
    {
        public userreg()
        {
            InitializeComponent();
        }
        read_write n = new read_write();
        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (type.Text == "مدیر")
                {
                    type.Text = "1";
                }
                else
                {
                    type.Text = "0";
                }
                bool c = n.write("insert into users values('" + codepers.Text + "','" + namepers.Text + " " + namekha.Text + "','" + ramz.Text + "','" + type.Text + "','" + tozih.Text + "')");
                if (c)
                {
                    MessageBox.Show("ذخیره شد");
                }
                else
                {
                    MessageBox.Show("ذخیره نشد");
                }

                codepers.Text = "";
                namepers.Text = "";
                namekha.Text = "";
                ramz.Text = "";
                type.Text = "";
                tozih.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("ذخیره نشد");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            codepers.Text = "";
            namepers.Text = "";
            namekha.Text = "";
            ramz.Text = "";
            type.Text = "";
            tozih.Text = "";
        }

        private void userreg_Load(object sender, EventArgs e)
        {
            
            type.Items.Add("مدیر");
            type.Items.Add("کاربر انباردار");
            type.Items.Add("کاربر صندوقدار");
            type.Items.Add("دکتر داروساز");
            DataSet t = n.read("select S_ID from sick order by S_ID desc");
            int id = 0;
            try
            {
                id = Convert.ToInt32(t.Tables[0].Rows[0][0].ToString());
                id = id + 1;
            }
            catch (Exception)
            {
            }
           

            DataSet saz = n.read("select I_Name from insurance_Company");
            
        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void ramz_TextChanged(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void codepers_TextChanged(object sender, EventArgs e)
        {

        }

        private void namekha_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void namepers_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
