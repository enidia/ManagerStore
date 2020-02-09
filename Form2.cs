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
    public partial class Form2 : Form
    {
        public string level2=null;
        public string username;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getusername = textBox1.Text.Trim();
            username = getusername;
            if (getusername != string.Empty)
            {
                string setusercode = textBox2.Text.Trim();
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string find = "select [商品库存管理].[dbo].[用户表].用户密码 "
                         + "from [商品库存管理].[dbo].[用户表]"
                         + "where [商品库存管理].[dbo].[用户表].用户名=" + "'" + getusername + "'";
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                int i=code.Fill(dt);
                if (i != 0)
                {
                    string usercode = dt.Tables[0].Rows[0]["用户密码"].ToString();



                    string sel = "select [商品库存管理].[dbo].[用户表].用户等级 "
                             + "from [商品库存管理].[dbo].[用户表]"
                             + "where [商品库存管理].[dbo].[用户表].用户名=" + "'" + getusername + "'";
                    SqlDataAdapter rank = new SqlDataAdapter(sel, conn);
                    DataSet ds = new DataSet();
                    rank.Fill(ds);
                    string commond = ds.Tables[0].Rows[0]["用户等级"].ToString().Trim();
                    conn.Close();
                    if (usercode.Trim() == setusercode)
                    {
                        if (commond.Trim() == "master")
                        {
                            level2 = "master";
                        }
                        else if (commond.Trim() == "security")
                        {
                            level2 = "security";
                        }
                        else if (commond.Trim() == "insert")
                        {
                            level2 = "insert";
                        }
                        else if (commond.Trim() == "inner")
                        {
                            level2 = "inner";
                        }
                        else if (commond.Trim() == "waiter")
                        {
                            level2 = "waiter";
                        }
                        else
                            MessageBox.Show("error name!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("密码错误重新输入！");
                }
                else
                    MessageBox.Show("不存在此用户名");
            }
            else
                this.textBox1.Text="输入用户名";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
