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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“商品库存管理DataSet9.商品”中。您可以根据需要移动或删除它。
            this.商品TableAdapter3.Fill(this.商品库存管理DataSet9.商品);
            // TODO: 这行代码将数据加载到表“商品库存管理DataSet8.商品”中。您可以根据需要移动或删除它。
            this.商品TableAdapter2.Fill(this.商品库存管理DataSet8.商品);
            // TODO: 这行代码将数据加载到表“商品库存管理DataSet7.商品”中。您可以根据需要移动或删除它。
            this.商品TableAdapter1.Fill(this.商品库存管理DataSet7.商品);
            // TODO: 这行代码将数据加载到表“商品库存管理DataSet6.商品”中。您可以根据需要移动或删除它。
            this.商品TableAdapter.Fill(this.商品库存管理DataSet6.商品);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = this.textBox1.Text.Trim();
            SqlConnection conn;
            conn = new SqlConnection("Data Source=.;Initial Catalog=商品库存管理;Integrated Security=True");
            conn.Open();
            string find = " select avg(进货价格) as price,avg([dbo].[商品].销售价格) as value,[dbo].[商品].商品类别"
                    + " from [dbo].[商品]"
                    +"  where[dbo].[商品].仓库编号='"+""+Convert.ToInt32(str.Trim())+""+"'"
                    +" group by [dbo].[商品].商品类别";
            SqlDataAdapter code = new SqlDataAdapter(find, conn);
            DataSet dt = new DataSet();
            code.Fill(dt, "perform");
            dataGridView1.DataSource = dt.Tables["perform"];
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
