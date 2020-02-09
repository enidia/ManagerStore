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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string rank;
        public string line;
        private void button1_Click(object sender, EventArgs e)
        {
                Form5 f5 = new Form5();
                f5.line = line;
                f5.Owner = this;
                f5.rank = rank;
                f5.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.rank7 = "master";
            f7.name = line;
            f7.Owner = this;
            f7.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.ShowDialog();
            f8.rank8 = "master";
        }
    }
}
