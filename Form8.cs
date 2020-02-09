using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
namespace 商品库存管理系统
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public string rank8;
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“商品库存管理DataSet1.商品”中。您可以根据需要移动或删除它。
            this.商品TableAdapter.Fill(this.商品库存管理DataSet1.商品);
            timer1.Interval = 500;
            timer1.Enabled = true;
        }
        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        public string find;
        private void button1_Click(object sender, EventArgs e)
        {
            if(chioce==true)//高级操作
            {
                string thingnumber = this.number.Text.Trim();
                string thingname = this.name.Text.Trim();
                string thingvolume = this.volume.Text.Trim();
                string thingprice = this.price.Text.Trim();
                string thingvalue = this.value.Text.Trim();
                string thingdescribe = this.describe.Text.Trim();
                string thingsort = this.sort.Text.Trim();
                string thingtomb = this.tomb.Text.Trim();


                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                         find = "select *"
                              + "from[商品库存管理].[dbo].[商品]"
                              + "where[dbo].[商品].商品编号 =[dbo].[商品].商品编号";
                if(thingnumber!=string.Empty)
                {
                    int thingcount = Convert.ToInt32(thingnumber);
                    find+= " and [商品库存管理].[dbo].[商品].商品编号=" +""+thingcount+"";
                }
                if(thingname!=string.Empty)
                {
                    find += " and [商品库存管理].[dbo].[商品].商品名称='" + thingname + "'";
                }
                if(thingvolume!=string.Empty)
                {
                    int thingv = Convert.ToInt32(thingvolume);
                    find += " and [商品库存管理].[dbo].[商品].库存量=" + ""+thingv+"";
                }
                if(thingprice!=string.Empty)
                {
                    float thingpri = float.Parse(thingprice);
                    find += " and [商品库存管理].[dbo].[商品].销售价格=" + "" + thingpri + "";
                }
                if (thingvalue != string.Empty)
                {
                    float thingval = float.Parse(thingvalue);
                    find += " and [商品库存管理].[dbo].[商品].进货价格=" + ""+thingval+"";
                }
                if (thingdescribe!=string.Empty)
                {
                    find += " and[商品库存管理].[dbo].[商品].商品描述='" + thingdescribe + "'";
                }
                if (thingsort!=string.Empty)
                {
                    int thingsor = Convert.ToInt32(thingsort);
                    find += " and [商品库存管理].[dbo].[商品].商品类别=" + "" + thingsor + "";
                }
                if (thingtomb!=string.Empty)
                {
                    int thingtom = Convert.ToInt32(thingtomb);
                    find += " and [商品库存管理].[dbo].[商品].仓库编号=" + "" + thingtom + "";
                }
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                code.Fill(dt, "perform");
                dataGridView1.DataSource = dt.Tables["perform"];
                conn.Close();
            }
            else if(choose==true)//普通操作
            {

                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                find = "select *"
                     + "from[商品库存管理].[dbo].[商品]"
                     + "where[dbo].[商品].商品编号 =[dbo].[商品].商品编号";
                if (normal.Text.Trim()=="商品编号")
                {
                    int thingcount = Convert.ToInt32(cell.Text.Trim());
                    find += " and [商品库存管理].[dbo].[商品].商品编号=" + "" + thingcount + "";
                }
                if (normal.Text.Trim()=="商品名称")
                {
                    find += " and [商品库存管理].[dbo].[商品].商品名称='" +cell.Text.Trim()+ "'";
                }
                if (normal.Text.Trim() == "库存量")
                {
                    int thingv = Convert.ToInt32(cell.Text.Trim());
                    find += " and [商品库存管理].[dbo].[商品].库存量=" + "" + thingv + "";
                }
                if (normal.Text.Trim() == "销售价格")
                {
                    float thingpri = float.Parse(cell.Text.Trim());
                    find += " and [商品库存管理].[dbo].[商品].销售价格=" + "" + thingpri + "";
                }
                if (normal.Text.Trim() == "进货价格")
                {
                    float thingval = float.Parse(cell.Text.Trim());
                    find += " and [商品库存管理].[dbo].[商品].进货价格=" + "" + thingval + "";
                }
                if (normal.Text.Trim() == "商品描述")
                {
                    find += " and[商品库存管理].[dbo].[商品].商品描述='" +cell.Text.Trim()+ "'";
                }
                if (normal.Text.Trim() == "商品类别")
                {
                    int thingsor = Convert.ToInt32(cell.Text.Trim());
                    find += " and [商品库存管理].[dbo].[商品].商品类别=" + "" + thingsor + "";
                }
                if (normal.Text.Trim() == "仓库编号")
                {
                    int thingtom = Convert.ToInt32(cell.Text.Trim());
                    find += " and [商品库存管理].[dbo].[商品].仓库编号=" + "" + thingtom + "";
                }
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                code.Fill(dt, "perform");
                dataGridView1.DataSource = dt.Tables["perform"];
                conn.Close();
            }
            else if(choosen==true)//模糊操作
            {
                SqlConnection conn;
                conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                conn.Open();
                find = "select *"
                     + "from[商品库存管理].[dbo].[商品]"
                     + "where[dbo].[商品].商品编号 =[dbo].[商品].商品编号";
                if (randomsupply.Text.Trim() == "商品名称")
                {
                    find += " and [商品库存管理].[dbo].[商品].商品名称  like '%" + randomupper.Text.Trim() + "%'";
                }
                if (randomsupply.Text.Trim() == "商品描述")
                {
                    find += " and [商品库存管理].[dbo].[商品].商品描述 like'%" + randomupper.Text.Trim() + "%'";
                }
                SqlDataAdapter code = new SqlDataAdapter(find, conn);
                DataSet dt = new DataSet();
                int i=code.Fill(dt, "perform");
                if (i != 0)
                {
                    dataGridView1.DataSource = dt.Tables["perform"];
                }
                else
                {
                    MessageBox.Show("模糊字段不存在");
                }
                conn.Close();
            }
        }

        public int getdata = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            string thingnumber = this.number.Text.Trim();
            string thingname = this.name.Text.Trim();
            string thingvolume = this.volume.Text.Trim();
            string thingprice = this.price.Text.Trim();
            string thingvalue = this.value.Text.Trim();
            string thingdescribe = this.describe.Text.Trim();
            string thingsort = this.sort.Text.Trim();
            string thingtomb = this.tomb.Text.Trim();
            int thingcount = Convert.ToInt32(thingnumber);
            if (thingnumber!=string.Empty)
            {
                Form6 f6 = new Form6();
                f6.Owner = this;
                f6.ShowDialog();
                getdata = f6.data;
                if (getdata > 0)
                {
                    SqlConnection conn;
                    conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
                    conn.Open();
                    string seek = "select [dbo].[商品].库存量"
                                + " from [dbo].[商品]"
                                + " where[dbo].[商品].商品编号 = " + "" + thingcount + "";
                    SqlDataAdapter rank = new SqlDataAdapter(seek, conn);
                    DataSet ds = new DataSet();
                    rank.Fill(ds);
                    string commond = ds.Tables[0].Rows[0]["库存量"].ToString().Trim();
                    int remain = Convert.ToInt32(commond);
                    if (remain > 0 && remain > getdata)
                    {
                        if (thingnumber != string.Empty)
                        {
                            int re = remain - getdata;
                            find = "update [商品库存管理].[dbo].[商品]"
                             + "set [商品库存管理].[dbo].[商品].库存量=" + "" + re + ""
                             + "where [商品库存管理].[dbo].[商品].商品编号=" + "" + thingcount + "";
                            SqlDataAdapter code = new SqlDataAdapter(find, conn);
                            DataSet dt = new DataSet();
                            code.Fill(dt, "perform");
                            dataGridView1.DataSource = dt.Tables["perform"];
                            string seel = "select*"
                                + " from [dbo].[商品]";
                            SqlDataAdapter code2 = new SqlDataAdapter(seel, conn);
                            DataSet dg = new DataSet();
                            code2.Fill(dg, "perform");
                            dataGridView1.DataSource = dg.Tables["perform"];
                        }
                        else
                            MessageBox.Show("需要商品编号");
                    }
                    conn.Close();
                }
                else
                    MessageBox.Show("输入商品数不正确");
            }
            else
                MessageBox.Show("必须取得商品编号");
        }
        private bool chioce = false;
        private bool choose = false;
        private bool choosen = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                chioce = true;
                choose = false;
                choosen = false;
                checkBox2.Checked = false;
                randomme.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            {
                choose = true;
                chioce = false;
                choosen = false;
                checkBox1.Checked = false;
                randomme.Checked = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void random_CheckedChanged(object sender, EventArgs e)
        {
            choosen = true;
            choose = false;
            chioce = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void volume_TextChanged(object sender, EventArgs e)
        {

        }

        private void value_TextChanged(object sender, EventArgs e)
        {

        }

        private void describe_TextChanged(object sender, EventArgs e)
        {

        }

        private void sort_TextChanged(object sender, EventArgs e)
        {

        }

        private void tomb_TextChanged(object sender, EventArgs e)
        {

        }

        private void upper_Click(object sender, EventArgs e)
        {
            if (normal.Text.Trim() == "商品编号")
            {
                this.number.Text = this.cell.Text.Trim();
            }
            else if (normal.Text.Trim() == "商品名称")
            {
                this.name.Text = this.cell.Text.Trim();
            }
            else if (normal.Text.Trim() == "库存量")
            {
                this.volume.Text = this.cell.Text.Trim();
            }
            else if (normal.Text.Trim() == "销售价格")
            {
                this.price.Text = this.cell.Text.Trim();
            }
            else if (normal.Text.Trim() == "进货价格")
            {
                this.value.Text = this.cell.Text.Trim();
            }
            else if (normal.Text.Trim() == "商品描述")
            {
                this.describe.Text = this.cell.Text.Trim();
            }
            else if (normal.Text.Trim() == "商品类别")
            {
                this.sort.Text = this.cell.Text.Trim();
            }
            else if (normal.Text.Trim() == "仓库编号")
            {
                this.tomb.Text = this.cell.Text.Trim();
            }
            else
                MessageBox.Show("不规范的注入式子！");//注入高级框
        }

        private void normal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cell_TextChanged(object sender, EventArgs e)
        {

        }

        private void randomupper_TextChanged(object sender, EventArgs e)
        {

        }

        private void randomsupply_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = label2.Text.Substring(1) + label2.Text.Substring(0, 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
