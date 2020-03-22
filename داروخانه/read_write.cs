using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;

namespace داروخانه
{
    class read_write
    {
        internal DataSet read(string query)
        {
            DataSet nds = new DataSet();
            try
            {
                SqlConnection nsqlc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hiwa\Desktop\WorkFolder\temp\DrugStore2\داروخانه\dragstore.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand get = new SqlCommand(query, nsqlc);
                nsqlc.Open();
                SqlDataAdapter nsda = new SqlDataAdapter(get);
                nsda.Fill(nds);
                nsqlc.Close();
                //  System.Windows.Forms.MessageBox.Show("success in read");
                return nds;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("خطا در خواندن دیتابیس");
                return nds;
            }
        }
        internal bool write(string query)
        {
            try
            {
            SqlConnection nsqlc = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=" + "\"" + "C:\\Users\\Hiwa\\Desktop\\WorkFolder\\temp\\DrugStore2\\داروخانه\\dragstore.mdf" + "\"" + ";Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand set = new SqlCommand(query, nsqlc);
                nsqlc.Open();
                SqlDataReader reader = set.ExecuteReader();
                reader.Close();
                nsqlc.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
