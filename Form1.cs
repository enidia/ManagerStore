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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string level1;
        private void button1_Click(object sender, EventArgs e)
        {
            level1 = null;
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.ShowDialog();
            level1 = f2.level2;
            if (level1 == "master")
            {
                Form3 f3 = new Form3();//什么都可以做
                f3.rank = "master";
                f3.line = f2.username;
                f3.Owner = this;
                f3.ShowDialog();
            }
            else if (level1 == "security")
            {
                    Form5 f5= new Form5();
                    f5.Owner = this;
                    f5.rank = "security";
                    f5.ShowDialog();
            }
            else if (level1 == "insert")
            {
                Form7 f7 = new Form7();
                f7.rank7 = "insert";
                f7.name = f2.username;
                f7.Owner = this;
                f7.ShowDialog();//只有插入以及插入时必要的更新
            }
            else if (level1 == "inner")
            {
                Form11 f11 = new Form11();
                f11.username11 = f2.username;
                f11.Owner = this;
                f11.ShowDialog();
            }
            else if (level1 == "waiter")
            {
                Form8 f8 = new Form8();
                f8.rank8 = "waiter";
                f8.Owner = this;
                f8.ShowDialog();//只有删除，以及数量上的更新
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level1 = null;
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.ShowDialog();
            if (f2.level2 != null)
            {
                Form9 f9 = new Form9();
                f9.username = f2.username;
                f9.Owner = this;
                f9.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
                f12.Owner = this;
            f12.ShowDialog();
        }
    }
}   

