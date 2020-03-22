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
    public partial class drugreg : Form
    {
        public drugreg()
        {
            InitializeComponent();
        }
        read_write n = new read_write();
        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (shekl.Text == "قرص")
                {
                    shekl.Text = "gors";
                }
                else if (shekl.Text == "sharbat")
                {
                    shekl.Text = "tazrigi";
                }
                else
                {
                    shekl.Text = "tazrigi";
                }

                if (noearze.Text == "عمده")
                {
                    noearze.Text = "0";
                }
                else
                {
                    noearze.Text = "1";
                }
                string datee = sal.Text + "/" + mah.Text + "/" + ruz.Text;
                bool c1 = n.write("insert into buy values('" + shfact.Text + "','" + datee + "','" + namedaru.Text + "','" + shekl.Text + "','" + geymat.Text + "','" + tedad.Text + "','" + kodekarbar.Text + "')");
                bool c2 = n.write("insert into store values('" + namedaru.Text + "','" + shekl.Text + "','" + geymat.Text + "','" + tedad.Text + "','" + noearze.Text + "')");

                if (c1 && c2)
                {
                    MessageBox.Show("ذخیره شد");
                }
                else
                {
                    MessageBox.Show("ذخیره نشد");
                }

                shfact.Text = "";
                sal.Text = "";
                mah.Text = "";
                ruz.Text = "";
                kodekarbar.Text = "";
                namedaru.Text = "";
                tedad.Text = "";
                geymat.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("ذخیره نشد");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            shfact.Text = "";
            sal.Text = "";
            mah.Text = "";
            ruz.Text = "";
            kodekarbar.Text = "";
            namedaru.Text = "";
            tedad.Text = "";
            geymat.Text = "";
            Close();
        }

        private void drugreg_Load(object sender, EventArgs e)
        {
            noearze.Items.Add("آزاد");
            noearze.Items.Add("با دستور پزشک");
            shekl.Items.Add("قرص");
            shekl.Items.Add("شربت");
            shekl.Items.Add("استنشاقی");
            shekl.Items.Add("پماد");
            shekl.Items.Add("تزریقی");
           
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

        private void button2_Click_2(object sender, EventArgs e)
        {
            Close();
        }
    }
}
