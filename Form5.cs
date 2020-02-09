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
    public partial class Form5 : Form
    {
        public string rank;
        public Form5()
        {
            InitializeComponent();
        }
        public string line;
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“商品库存管理DataSet.用户表”中。您可以根据需要移动或删除它。
            this.用户表TableAdapter.Fill(this.商品库存管理DataSet.用户表);
        }
        public string name;
        private void button3_Click(object sender, EventArgs e)
        {
            if(cater==1)
            {
                Form4 f4 = new Form4();
                f4.Owner = this;
                f4.line = line;
                f4.judge = this.rank;
                f4.ShowDialog();
                if (f4.centect == 1)
                {
                    Form10 account = new Form10();
                    account.Owner = this;
                    account.ShowDialog();
                    name = account.name;
                    string code = this.textBox1.Text.Trim();
                    if (code != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string charge = "update [商品库存管理].[dbo].[用户表]"
                                       + "set [商品库存管理].[dbo].[用户表].用户密码='" + code + "'"
                                       + "where [商品库存管理].[dbo].[用户表].用户名='" + name.Trim()+ "'";
                        SqlDataAdapter c1 = new SqlDataAdapter(charge, conn);
                        DataSet cou = new DataSet();
                        int i = c1.Fill(cou);
                        if (i != 0)
                        {
                            MessageBox.Show("成功修改密码");
                        }
                        else
                            MessageBox.Show("成功修改密码");
                        conn.Close();
                    }
                    else
                    { }
                    string getname = this.textBox2.Text.Trim();
                    if (getname != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string save = "update [商品库存管理].[dbo].[用户表]"
                                       + "set [商品库存管理].[dbo].[用户表].用户名='" + getname + "'"
                                       + "where [商品库存管理].[dbo].[用户表].用户名='" + name + "'";
                        SqlDataAdapter c2 = new SqlDataAdapter(save, conn);
                        DataSet cou2 = new DataSet();
                        int i = c2.Fill(cou2);
                        if (i != 0)
                        {
                            MessageBox.Show("成功修改用户名");
                        }
                        else
                        {
                            MessageBox.Show("成功修改用户名");
                        }
                        conn.Close();
                    }
                    else
                    { }
                }
                else
                { }
            }
            else
            MessageBox.Show("输入要更改的东西");
        }
        private int cater = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            matter = this.comboBox1.Text;
            if (matter.Trim() == "用户名" || matter.Trim() == "用户编号")
            {
                string cell = this.textBox3.Text.Trim();
                if (cell.Trim() != string.Empty)
                {
                    if (matter == "用户名")
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "delete"
                                 + " from [商品库存管理].[dbo].[用户表]"
                                 + " where [商品库存管理].[dbo].[用户表].用户名=" + "'" + cell + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        int i = code.Fill(dt, "perform");
                        if (i != 0)
                        {
                            MessageBox.Show("删除成功");
                        }
                        else
                            MessageBox.Show("删除成功");
                        string find3 = "select*"
                                     + " from [商品库存管理].[dbo].[用户表]";
                        SqlDataAdapter code3 = new SqlDataAdapter(find3, conn);
                        DataSet dt3 = new DataSet();
                        code3.Fill(dt3, "perform");
                        dataGridView1.DataSource = dt3.Tables["perform"];
                        conn.Close();
                    }
                    if (matter == "用户编号")
                    {
                        int a = Convert.ToInt32(cell);
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find2 = "delete"
                                 + " from [商品库存管理].[dbo].[用户表]"
                                 + " where [商品库存管理].[dbo].[用户表].用户编号=" + "" + a + "";
                        SqlDataAdapter code2 = new SqlDataAdapter(find2, conn);
                        DataSet ds = new DataSet();
                        int k = code2.Fill(ds, "perform");
                        if (k != 0)
                        {
                            MessageBox.Show("删除成功");
                        }
                        else
                            MessageBox.Show("删除成功");
                        string find3 = "select*"
                                     + " from [商品库存管理].[dbo].[用户表]";
                        SqlDataAdapter code3 = new SqlDataAdapter(find3, conn);
                        DataSet dt3 = new DataSet();
                        code3.Fill(dt3, "perform");
                        dataGridView1.DataSource = dt3.Tables["perform"];
                        conn.Close();
                    }
                }
                else
                    MessageBox.Show("输入操作项目");
            }
            else
                MessageBox.Show("只能通过用户名或是编号来删除");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cater = 1;//密码
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cater = 1;//用户
        }
        private string matter = null;
        private void button1_Click(object sender, EventArgs e)
        {
            matter = this.comboBox1.Text;
            if (matter.Trim() != string.Empty)
            {
                string cell = this.textBox3.Text.Trim();
                if (cell.Trim() != string.Empty)
                {
                    if (matter == "用户名")
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "select*"
                                 + " from [商品库存管理].[dbo].[用户表]"
                                 + " where [商品库存管理].[dbo].[用户表].用户名=" + "'" + cell + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        int i = code.Fill(dt, "perform");
                        if (i == 0)
                        {
                            MessageBox.Show("查询项有误，重新输入");
                        }
                        else
                        {
                            dataGridView1.DataSource = dt.Tables["perform"];
                        }
                        conn.Close();
                    }
                    if (matter == "用户等级")
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find2 = "select*"
                                 + " from [商品库存管理].[dbo].[用户表]"
                                 + " where [商品库存管理].[dbo].[用户表].用户等级='" + cell + "'";
                        SqlDataAdapter code2 = new SqlDataAdapter(find2, conn);
                        DataSet ds = new DataSet();
                        int i = code2.Fill(ds, "perform");
                        if (i == 0)
                        {
                            MessageBox.Show("查询项有误，重新输入");
                        }
                        else
                        {
                            dataGridView1.DataSource = ds.Tables["perform"];
                        }
                        conn.Close();
                    }
                    if (matter == "用户编号")
                    {
                        int a = Convert.ToInt32(cell);
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find2 = "select*"
                                 + " from [商品库存管理].[dbo].[用户表]"
                                 + " where [商品库存管理].[dbo].[用户表].用户编号=" + "" + a + "";
                        SqlDataAdapter code2 = new SqlDataAdapter(find2, conn);
                        DataSet ds = new DataSet();
                        int c = code2.Fill(ds, "perform");
                        if (c == 0)
                        {
                            MessageBox.Show("查询项有误，重新输入");
                        }
                        else
                        {
                            dataGridView1.DataSource = ds.Tables["perform"];
                        }
                        conn.Close();
                    }
                }
                if (matter == "显示所有")
                {
                    SqlConnection conn;
                    conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                    conn.Open();
                    string find3 = "select*"
                             + " from [商品库存管理].[dbo].[用户表]";
                    SqlDataAdapter code3 = new SqlDataAdapter(find3, conn);
                    DataSet dt3 = new DataSet();
                    code3.Fill(dt3, "perform");
                    dataGridView1.DataSource = dt3.Tables["perform"];
                    conn.Close();
                }
            }
            else
                MessageBox.Show("操作项不能为空");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Trim()!=string.Empty&&this.textBox5.Text.Trim()!=string.Empty && this.textBox6.Text.Trim()!=string.Empty && this.comboBox2.Text.Trim()!=string.Empty)
            {
                if (this.comboBox2.Text.Trim() == "master")
                {
                    Form4 f4 = new Form4();
                    f4.Owner = this;
                    f4.judge = this.rank;
                    f4.ShowDialog();
                    if (f4.centect == 1)
                    {
                        int clientnumber = Convert.ToInt32(this.textBox4.Text.Trim());
                        string clientname = this.textBox5.Text.Trim();
                        string clientcode = this.textBox6.Text.Trim();
                        string clientpower = this.comboBox2.Text.Trim();
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "insert into[商品库存管理].[dbo].[用户表] values(" + "" + clientnumber + "" + ", '" + clientname + "', '" + clientcode + "', '" + clientpower + "')";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        string find2 = "select*"
                                       + " from [商品库存管理].[dbo].[用户表]"
                                       + " where [商品库存管理].[dbo].[用户表].用户编号=" + "" + clientnumber + "";
                        SqlDataAdapter code5 = new SqlDataAdapter(find2, conn);
                        DataSet dg = new DataSet();
                        code5.Fill(dg, "perform");
                        dataGridView1.DataSource = dg.Tables["perform"];
                        MessageBox.Show("插入成功！");
                        conn.Close();
                    }
                    else
                        MessageBox.Show("重新输入密码");
                }
                else if(this.comboBox2.Text.Trim()=="security"|| this.comboBox2.Text.Trim() == "insert" || this.comboBox2.Text.Trim() == "inner" || this.comboBox2.Text.Trim() == "waiter")
                {
                    int clientnumber = Convert.ToInt32(this.textBox4.Text.Trim());
                    string clientname = this.textBox5.Text.Trim();
                    string clientcode = this.textBox6.Text.Trim();
                    string clientpower = this.comboBox2.Text.Trim();
                    SqlConnection conn;
                    conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                    conn.Open();
                    string find = "insert into[商品库存管理].[dbo].[用户表] values(" + "" + clientnumber + "" + ", '" + clientname + "', '" + clientcode + "', '" + clientpower + "')";
                    SqlDataAdapter code = new SqlDataAdapter(find, conn);
                    DataSet dt = new DataSet();
                    code.Fill(dt, "perform");
                    string find2 = "select*"
                                   + " from [商品库存管理].[dbo].[用户表]"
                                   + " where [商品库存管理].[dbo].[用户表].用户编号=" + "" + clientnumber + "";
                    SqlDataAdapter code5 = new SqlDataAdapter(find2, conn);
                    DataSet dg = new DataSet();
                    code5.Fill(dg, "perform");
                    dataGridView1.DataSource = dg.Tables["perform"];
                    MessageBox.Show("插入成功！");
                    conn.Close();
                }
                this.comboBox1.Text = "显示所有";
            }
            else
                MessageBox.Show("请填写满！");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
