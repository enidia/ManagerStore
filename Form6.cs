using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 商品库存管理系统
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string rank6;
        private void Form6_Load(object sender, EventArgs e)
        {

        }
        public int data=0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == string.Empty)
            {
                data = 0;
                this.Close();
            }
            else
            {
                data = Convert.ToInt32(this.textBox1.Text.Trim());
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
