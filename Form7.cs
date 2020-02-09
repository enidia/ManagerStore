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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public string rank7;
        public string name;
        private void Form7_Load(object sender, EventArgs e)
        {
            int cache,cat;
            timer1.Interval = 500;
            timer1.Enabled = true;
            string year = DateTime.Now.Year.ToString();
            for(int i=0;i<6;i++)
            {
                comboBox1.Items.Add(year);
                int count = Convert.ToInt32(year);
                count--;
                year = count.ToString();
            }
            string month = DateTime.Now.Month.ToString();
            for(cache=0;cache<12;cache++)
            {
                int count = Convert.ToInt32(month);
                if (count == 0)
                {
                    break;
                }
                comboBox2.Items.Add(month);
                count--;
                month = count.ToString();
            }
            string day = DateTime.Now.Day.ToString();
            for (cat = 0; cat < 31; cat++)
            {
                int count = Convert.ToInt32(day);
                if (count == 0)
                {
                    break;
                }
                comboBox3.Items.Add(day);
                count--;
                day = count.ToString();
            }
            SqlConnection conn;
            conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
            conn.Open();
            string find = "select *"
                 + " from [商品库存管理].[dbo].[商品],[商品库存管理].[dbo].[供应商]"
                 + " where[dbo].[商品].商品编号=[商品库存管理].[dbo].[供应商].商品编号";
            SqlDataAdapter code = new SqlDataAdapter(find, conn);
            DataSet dt = new DataSet();
            code.Fill(dt, "perform");
            dataGridView1.DataSource = dt.Tables["perform"];
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void datebutton_Click(object sender, EventArgs e)
        {
            string year = this.dateTimePicker1.Value.ToString("yyyy");
            string month = this.dateTimePicker1.Value.ToString("MM");
            string day = this.dateTimePicker1.Value.ToString("dd");
            this.comboBox1.Text = year.Trim();
            this.comboBox2.Text = month.Trim();
            this.comboBox3.Text = day.Trim();
        }
        private void thingnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime getup = this.dateTimePicker1.Value;
            DateTime getdown = this.dateTimePicker2.Value;
            SqlConnection conn;
            conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
            conn.Open();
            string find = "select *"
                 + " from [商品库存管理].[dbo].[商品],[商品库存管理].[dbo].[供应商]"
                 + " where[dbo].[商品].商品编号=[商品库存管理].[dbo].[供应商].商品编号"
                 + " and [dbo].[供应商].录入时间<'" + getup + "'"
                 + " and [dbo].[供应商].录入时间>'" + getdown + "'";
            SqlDataAdapter code = new SqlDataAdapter(find, conn);
            DataSet dt = new DataSet();
            code.Fill(dt, "perform");
            dataGridView1.DataSource = dt.Tables["perform"];
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text != string.Empty && this.comboBox2.Text == string.Empty && this.comboBox3.Text == string.Empty)
            {
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string find = "select *"
                     + " from [商品库存管理].[dbo].[商品],[商品库存管理].[dbo].[供应商]"
                     + " where[dbo].[商品].商品编号=[商品库存管理].[dbo].[供应商].商品编号"
                     + " and  [dbo].[供应商].录入时间<'" + (Convert.ToInt32(comboBox1.Text.Trim()) + 1).ToString() + "'"
                     + " and [dbo].[供应商].录入时间 >'" + comboBox1.Text.Trim().ToString() + "'";
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                code.Fill(dt, "perform");
                dataGridView1.DataSource = dt.Tables["perform"];
                conn.Close();
            }
            else if (this.comboBox1.Text != string.Empty && this.comboBox2.Text != string.Empty && this.comboBox3.Text == string.Empty)
            {
                string a = "1";
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string find = "select *"
                     + " from [商品库存管理].[dbo].[商品],[商品库存管理].[dbo].[供应商]"
                     + " where[dbo].[商品].商品编号=[商品库存管理].[dbo].[供应商].商品编号"
                     + " and  [dbo].[供应商].录入时间<'" + comboBox1.Text.Trim().ToString() + "-" + (Convert.ToInt32(comboBox2.Text.Trim()) + 1).ToString() + "-" + a + "'"
                     + " and [dbo].[供应商].录入时间 >'" + comboBox1.Text.Trim().ToString() + "-" + comboBox2.Text.Trim().ToString() + "-" + a + "'";
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                code.Fill(dt, "perform");
                dataGridView1.DataSource = dt.Tables["perform"];
                conn.Close();
            }
            else if (this.comboBox1.Text != string.Empty && this.comboBox2.Text != string.Empty && this.comboBox3.Text != string.Empty)
            {
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string find = "select *"
                     + " from [商品库存管理].[dbo].[商品],[商品库存管理].[dbo].[供应商]"
                     + " where[dbo].[商品].商品编号=[商品库存管理].[dbo].[供应商].商品编号"
                     + " and  [dbo].[供应商].录入时间='" + comboBox1.Text.Trim().ToString() + "-" + comboBox2.Text.Trim().ToString() + "-" + comboBox3.Text.Trim().ToString() + "'";
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                code.Fill(dt, "perform");
                dataGridView1.DataSource = dt.Tables["perform"];
                conn.Close();
            }
            else
            {
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string find = "select *"
                     + " from [商品库存管理].[dbo].[商品],[商品库存管理].[dbo].[供应商]"
                     + " where[dbo].[商品].商品编号=[商品库存管理].[dbo].[供应商].商品编号";
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                code.Fill(dt, "perform");
                dataGridView1.DataSource = dt.Tables["perform"];
                conn.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void insert_Click(object sender, EventArgs e)
        {
            string thnum = thingnumber.Text.Trim();
            string thname = thingname.Text.Trim();
            string re = thingremain.Text.Trim();
            string salep = saleprice.Text.Trim();
            string getp = getprice.Text.Trim();
            string des = describe.Text.Trim();
            string sort = thingsort.Text.Trim();
            string tanknum = tanknumber.Text.Trim();
            string busnum = businessnumber.Text.Trim();
            string busname = businessname.Text.Trim();
            string bustele = businesstele.Text.Trim();
            string buslac = businesslocation.Text.Trim();
            string valueed = thingvalue.Text.Trim();
            if (thnum != string.Empty && thname != string.Empty && re != string.Empty && salep != string.Empty && getp != string.Empty && des != string.Empty && sort != string.Empty && tanknum != string.Empty && busnum != string.Empty && busname != string.Empty && bustele != string.Empty && buslac != string.Empty && valueed != string.Empty)
            {
                SqlConnection conn1;
                conn1 = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn1.Open();
                string find1 = "insert into [商品库存管理].[dbo].[商品] values('" + Convert.ToInt32(thnum) + "','" + thname + "','" + Convert.ToInt32(re) + "','" + float.Parse(salep) + "','" + float.Parse(getp) + "','" + des + "','" + Convert.ToInt32(sort) + "','" + Convert.ToInt32(tanknum) + "')";
                SqlDataAdapter code1 = new SqlDataAdapter(find1, conn1);
                DataSet dt1 = new DataSet();
                code1.Fill(dt1, "perform");
                conn1.Close();
                SqlConnection conn2;
                conn2 = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn2.Open();
                string find2 = "insert into [商品库存管理].[dbo].[供应商] values('" + Convert.ToInt32(busnum) + "','" + busname + "','" + Convert.ToInt32(bustele) + "','" + buslac + "','" + Convert.ToInt32(thnum) + "','" + thname + "','" + float.Parse(valueed) + "','" + DateTime.Now + "','" + this.name + "')";
                SqlDataAdapter code2 = new SqlDataAdapter(find2, conn2);
                DataSet dt2 = new DataSet();
                code2.Fill(dt2, "perform2");
                conn2.Close();
            }
            else
            {
                MessageBox.Show("输入完整的一行");
            }
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string find = "select *"
                     + " from [商品库存管理].[dbo].[商品],[商品库存管理].[dbo].[供应商]"
                     + " where[dbo].[商品].商品编号=[商品库存管理].[dbo].[供应商].商品编号";
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                code.Fill(dt, "perform");
                dataGridView1.DataSource = dt.Tables["perform"];
                conn.Close();
                MessageBox.Show("录入成功");
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (this.rank7 != "insert")
            {
                string thnum = thingnumber.Text.Trim();
                string thname = thingname.Text.Trim();
                string re = thingremain.Text.Trim();
                string salep = saleprice.Text.Trim();
                string getp = getprice.Text.Trim();
                string des = describe.Text.Trim();
                string sort = thingsort.Text.Trim();
                string tanknum = tanknumber.Text.Trim();
                string busnum = businessnumber.Text.Trim();
                string busname = businessname.Text.Trim();
                string bustele = businesstele.Text.Trim();
                string buslac = businesslocation.Text.Trim();
                string valueed = thingvalue.Text.Trim();
                if (thnum != string.Empty)
                {
                    if (thname != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[商品]"
                            + " set 商品名称='" + thname + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (re != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[商品]"
                            + " set 库存量='" + "" + Convert.ToInt32(re) + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (salep != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[商品]"
                            + " set 销售价格='" + "" + float.Parse(salep) + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (getp != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[商品]"
                            + " set 进货价格='" + "" + float.Parse(getp) + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (des != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[商品]"
                            + " set 商品描述='" + des + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (sort != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[商品]"
                            + " set 商品类别='" + "" + Convert.ToInt32(sort) + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (tanknum != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[商品]"
                            + " set 仓库编号='" + "" + Convert.ToInt32(tanknum) + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (busnum != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[供应商]"
                            + " set 供应商编号='" + "" + Convert.ToInt32(busnum) + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (busname != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[供应商]"
                            + " set 供应商名称='" + "" + busname + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (bustele != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[供应商]"
                            + " set 供应商电话='" + "" + Convert.ToInt32(bustele) + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (buslac != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[供应商]"
                            + " set 供应商地址='" + "" + buslac + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (thname != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[供应商]"
                            + " set 商品名称='" + thname + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                    if (valueed != string.Empty)
                    {
                        SqlConnection conn;
                        conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn.Open();
                        string find = "update [dbo].[供应商]"
                            + " set 成本价格='" + "" + float.Parse(valueed) + "" + "'"
                            + " where 商品编号='" + "" + thnum + "" + "'";
                        SqlDataAdapter code = new SqlDataAdapter(find, conn);
                        DataSet dt = new DataSet();
                        code.Fill(dt, "perform");
                        conn.Close();
                    }
                        SqlConnection conn2;
                        conn2 = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                        conn2.Open();
                        string find2 = " update [商品库存管理].[dbo].[供应商]"
                            + " set 录入时间='" + DateTime.Now + "'"
                            + " update[商品库存管理].[dbo].[供应商]"
                            + " set 操作人员='" + this.name + "'";
                        SqlDataAdapter code2 = new SqlDataAdapter(find2, conn2);
                        DataSet dt2 = new DataSet();
                        code2.Fill(dt2, "perform2");
                        conn2.Close();
                }
                else
                    MessageBox.Show("输入必要的商品编号！");
            }
            else
                MessageBox.Show("权限不足！");
        }

        private void businessname_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (this.rank7 != "insert")
            {
                string thnum = thingnumber.Text.Trim();
                string thname = thingname.Text.Trim();
                string re = thingremain.Text.Trim();
                string salep = saleprice.Text.Trim();
                string getp = getprice.Text.Trim();
                string des = describe.Text.Trim();
                string sort = thingsort.Text.Trim();
                string tanknum = tanknumber.Text.Trim();
                string busnum = businessnumber.Text.Trim();
                string busname = businessname.Text.Trim();
                string bustele = businesstele.Text.Trim();
                string buslac = businesslocation.Text.Trim();
                string valueed = thingvalue.Text.Trim();
                if (thnum != string.Empty)
                {
                    SqlConnection conn;
                    conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                    conn.Open();
                    string find = "delete"
                        + " from [商品库存管理].[dbo].[商品]"
                        + " where 商品编号='" + "" + thnum + "" + "'";
                    SqlDataAdapter code = new SqlDataAdapter(find, conn);
                    DataSet dt = new DataSet();
                    code.Fill(dt, "perform");
                    conn.Close();
                    SqlConnection conn2;
                    conn2 = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                    conn2.Open();
                    string find2 = "delete"
                        + " from [商品库存管理].[dbo].[供应商]  "
                        + " where 商品编号='" + "" + thnum + "" + "'";
                    SqlDataAdapter code2 = new SqlDataAdapter(find2, conn2);
                    DataSet dt2 = new DataSet();
                    code2.Fill(dt2, "perform2");
                    conn2.Close();
                }
                else
                    MessageBox.Show("输入商品编号");
            }
            else
                MessageBox.Show("权限不足！");
        }

        private void seek_Click(object sender, EventArgs e)
        {
            if (this.rank7 != "insert")
            {
                string oppel = textBox2.Text.Trim();
                string thnum = thingnumber.Text.Trim();
                string thname = thingname.Text.Trim();
                string re = thingremain.Text.Trim();
                string salep = saleprice.Text.Trim();
                string getp = getprice.Text.Trim();
                string des = describe.Text.Trim();
                string sort = thingsort.Text.Trim();
                string tanknum = tanknumber.Text.Trim();
                string busnum = businessnumber.Text.Trim();
                string busname = businessname.Text.Trim();
                string bustele = businesstele.Text.Trim();
                string buslac = businesslocation.Text.Trim();
                string valueed = thingvalue.Text.Trim();
                textBox2.Text= string.Empty;
                thingnumber.Text = string.Empty;
                thingname.Text = string.Empty;
                thingremain.Text = string.Empty;
                saleprice.Text = string.Empty;
                getprice.Text = string.Empty;
                describe.Text = string.Empty;
                thingsort.Text = string.Empty;
                tanknumber.Text = string.Empty;
                businessnumber.Text = string.Empty;
                businessname.Text = string.Empty;
                businesstele.Text = string.Empty;
                businesslocation.Text = string.Empty;
                thingvalue.Text = string.Empty;
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                string find = "select *"
                     + " from [商品库存管理].[dbo].[商品],[商品库存管理].[dbo].[供应商]"
                     + " where[dbo].[商品].商品编号=[商品库存管理].[dbo].[供应商].商品编号";
                if (thnum != string.Empty)
                {
                    find += " and [dbo].[商品].商品编号='" + thnum + "'";
                }
                if (thname != string.Empty)
                {
                    find += " and [dbo].[商品].商品名称='" + thname + "'";
                }
                if (re != string.Empty)
                {
                    find += " and [dbo].[商品].库存量='" + "" + Convert.ToInt32(re) + "" + "'";
                }
                if (salep != string.Empty)
                {
                    find += " and [dbo].[商品].销售价格='" + "" + float.Parse(salep) + "" + "'";
                }
                if (getp != string.Empty)
                {
                    find += " and [dbo].[商品].进货价格='" + "" + float.Parse(getp) + "" + "'";
                }
                if (des != string.Empty)
                {
                    find += " and [dbo].[商品].商品描述='" + des + "'";
                }
                if (sort != string.Empty)
                {
                    find += " and [dbo].[商品].商品类别='" + "" + Convert.ToInt32(sort) + "" + "'";
                }
                if (tanknum != string.Empty)
                {
                    find += " and [dbo].[商品].仓库编号='" + "" + Convert.ToInt32(tanknum) + "" + "'";
                }
                if (busnum != string.Empty)
                {
                    find += " and [dbo].[供应商].供应商编号='" + "" + Convert.ToInt32(busnum) + "" + "'";
                }
                if (busname != string.Empty)
                {
                    find += " and [dbo].[供应商].供应商名称='" + "" + busname + "" + "'";
                }
                if (bustele != string.Empty)
                {
                    find += " and [dbo].[供应商].供应商电话='" + "" + Convert.ToInt32(bustele) + "" + "'";
                }
                if (buslac != string.Empty)
                {
                    find += " and [dbo].[供应商].供应商地址='" + "" + buslac + "" + "'";
                }
                if (thname != string.Empty)
                {
                    find += " and [dbo].[供应商].商品名称='" + thname + "'";
                }
                if (valueed != string.Empty)
                {
                    find += " and [dbo].[供应商].成本价格='" + "" + float.Parse(valueed) + "" + "'";
                }
                if (oppel != string.Empty)
                {
                    find += " and [dbo].[供应商].操作人员='" + oppel+ "'";
                }
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                code.Fill(dt, "perform");
                dataGridView1.DataSource = dt.Tables["perform"];
                conn.Close();
            }
            else
                MessageBox.Show("权限不足!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = label17.Text.Substring(1) + label17.Text.Substring(0, 1);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
