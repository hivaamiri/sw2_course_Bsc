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
    public partial class patreg : Form
    {
        public patreg()
        {
            InitializeComponent();
        }
        read_write n = new read_write();
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                bool c = n.write("insert into sick values('" + kodebimar.Text + "','" + shomaredaf.Text + "','" + namebimar.Text + " " + bimarnamekha.Text + "','" + sazmanebimegar.Text + "')");
                if (c)
                {
                    MessageBox.Show("ذخیره شد");
                }
                else
                {
                    MessageBox.Show("ذخیره نشد");
                }

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
                kodebimar.Text = id.ToString();
                shomaredaf.Text = "";
                namebimar.Text = "";
                bimarnamekha.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("  ذخیره نشد");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
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
            kodebimar.Text = id.ToString();
            shomaredaf.Text = "";
            namebimar.Text = "";
            bimarnamekha.Text = "";
            Close();
        }

        private void patreg_Load(object sender, EventArgs e)
        {
            
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
            kodebimar.Text = id.ToString();

            DataSet saz = n.read("select I_Name from insurance_Company");
            //for (int i = 0; i < saz.Tables[0].Rows.Count; i++)
           // {
           //     sazmanebimegar.Items.Add(saz.Tables[0].Rows[i][0].ToString());
           // }
        }
    }
}
