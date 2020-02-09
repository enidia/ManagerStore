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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public int centect=0;
        public string judge;
        public string line;
        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text.Trim();
            SqlConnection conn;
            conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
            conn.Open();
            string find = "select [商品库存管理].[dbo].[用户表].用户密码 "
                     + "from [商品库存管理].[dbo].[用户表]"
                     + "where [商品库存管理].[dbo].[用户表].用户名=" + "'"+line+"'";
            SqlDataAdapter apply = new SqlDataAdapter(find, conn);
            DataSet dt = new DataSet();
            int i=apply.Fill(dt);
            if (i != 0)
            {
                string usercode = dt.Tables[0].Rows[0]["用户密码"].ToString();
                conn.Close();
                if (usercode.Trim() == code)
                {
                    centect = 1;
                    this.Close();
                }
                else
                { }
            }
            else
                MessageBox.Show("输入有误");
            conn.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
