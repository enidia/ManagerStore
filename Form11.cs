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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        public string username11;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.name = username11;
            f7.rank7 = "inner";
            f7.Owner = this;
            f7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.ShowDialog();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = username11;
            timer1.Interval = 400;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text.Substring(1) + this.textBox1.Text.Substring(0, 1);
        }
    }
}
