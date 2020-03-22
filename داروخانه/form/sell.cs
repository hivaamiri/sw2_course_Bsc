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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void فروشداروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 n = new Form2();
            n.ShowDialog();
        }

      
        read_write rw = new read_write();
        private void Form2_Load(object sender, EventArgs e)
        {
            //DataSet nds = rw.read("select D_Name,D_shap,D_Price from store");
            //dataGridView3.DataSource = nds.Tables[0];
            
           
        }
        string nameofmedic = "";
        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (dataGridView3.Rows[i].Cells[0].Selected)
                {
                    nameofmedic = dataGridView3.Rows[i].Cells[0].Value.ToString();
                }
            }
        }
        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameofmedic!="")
            {
                DataSet tmp = rw.read("select D_Name,D_shap,D_Price,D_Total from store where (D_Name = N'"+nameofmedic+"')");
                dataGridView4.RowCount = i;
                dataGridView4.Rows[i - 1].Cells[0].Value = tmp.Tables[0].Rows[0][0].ToString();
                dataGridView4.Rows[i - 1].Cells[1].Value = tmp.Tables[0].Rows[0][1].ToString();
                dataGridView4.Rows[i - 1].Cells[2].Value = tmp.Tables[0].Rows[0][2].ToString();
                dataGridView4.Rows[i - 1].Cells[3].Value = "1";
                if (radioButton1.Checked==true)
                {
                    dataGridView4.Rows[i - 1].Cells[4].Value = "50%";
                }
                else
                {
                    dataGridView4.Rows[i - 1].Cells[4].Value = "0%";
                }
                dataGridView4.Columns[3].ReadOnly = false;
                i = i + 1;
            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (dataGridView3.Rows[i].Cells[0].Selected)
                {
                    nameofmedic = dataGridView3.Rows[i].Cells[0].Value.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            bool t = true;
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                DataSet tmp = rw.read("select D_Total from store where (D_Name = N'" + dataGridView4.Rows[i].Cells[0].Value.ToString() + "')");
                
                if (Convert.ToInt32(tmp.Tables[0].Rows[0][0].ToString())>=Convert.ToInt32(dataGridView4.Rows[i].Cells[3].Value.ToString()))
                {

                }
                else
                {
                    MessageBox.Show("این تعداد موجود نیست");
                    t = false;
                }
            }
            if (t)
            {
                for (int i = 0; i < dataGridView4.RowCount; i++)
                {
                    DataSet tmp = rw.read("select D_Total from store where (D_Name = N'" + dataGridView4.Rows[i].Cells[0].Value.ToString() + "')");
                    int newt = Convert.ToInt32(tmp.Tables[0].Rows[0][0].ToString()) - Convert.ToInt32(dataGridView4.Rows[i].Cells[3].Value.ToString());
                    rw.write("UPDATE store SET  D_Total = N'" + newt.ToString() + "' WHERE (D_Name = N'" + dataGridView4.Rows[i].Cells[0].Value.ToString() + "')");
                }
                int geymatt = 0;
                for (int i = 0; i < dataGridView4.RowCount; i++)
                {
                    if (radioButton1.Checked == true)
                    {
                        geymatt += (Convert.ToInt32(dataGridView4.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView4.Rows[i].Cells[3].Value)) / 2;
                    }
                    else
                    {
                        geymatt += Convert.ToInt32(dataGridView4.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView4.Rows[i].Cells[3].Value);
                    }

                }
                label12.Text = geymatt.ToString();
                string datee = sal.Text + "/" + mah.Text + "/" + ruz.Text;
                
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 1;
            kodebimar.Text = "";
            namedoktor.Text = "";
            hagefani.Text = "";
            sal.Text = "";
            mah.Text = "";
            ruz.Text = "";
            label12.Text = "0";
            dataGridView4.Rows.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            patreg n = new patreg();
            n.ShowDialog();
        }
    }
}
