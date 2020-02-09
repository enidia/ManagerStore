using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 商品库存管理系统
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public string name;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = this.textBox1.Text.Trim();
            if (name1 != string.Empty)
            {
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string find = "select*"
                         + " from [商品库存管理].[dbo].[用户表]"
                         + " where [商品库存管理].[dbo].[用户表].用户名=" + "'" + name1 + "'";
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                int i = code.Fill(dt, "perform");
                if (i == 0)
                {
                    MessageBox.Show("输入有误，重新输入");
                }
                else
                    this.name = name1.Trim();
                conn.Close();
            }
            else
            { }
            this.Close();
        }
    }
}
