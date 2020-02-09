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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public string username;
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code1 = this.textBox1.Text.Trim();
            string code2 = this.textBox2.Text.Trim();
            if (code1 == code2&&code1!=string.Empty)
            {
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string change = "update [商品库存管理].[dbo].[用户表]"
                               + "set [商品库存管理].[dbo].[用户表].用户密码='" + code1 + "'"
                               + "where [商品库存管理].[dbo].[用户表].用户名='" + username + "'";
                SqlDataAdapter c1 = new SqlDataAdapter(change, conn);
                DataSet cou = new DataSet();
                MessageBox.Show("成功修改\n当前密码是" + code1);
                conn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码输入不匹配或未输入密码");
                this.Close();
            }

            if (this.textBox3.Text.Trim()!=string.Empty)
            {
                string name1 = this.textBox3.Text.Trim();
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string changename = "update [商品库存管理].[dbo].[用户表]"
                               + "set [商品库存管理].[dbo].[用户表].用户名='" +name1+ "'"
                               + "where [商品库存管理].[dbo].[用户表].用户名='" + username + "'";
                SqlDataAdapter c2 = new SqlDataAdapter(changename, conn);
                DataSet nm = new DataSet();
                int i=c2.Fill(nm);
                MessageBox.Show("成功修改\n当前用户名是" + name1);
                conn.Close();
            }
            else
            {
                MessageBox.Show("未输入用户名");
                this.Close();
            }
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
