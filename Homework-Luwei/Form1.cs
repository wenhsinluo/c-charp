using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Luwei
{
    public partial class Form1 : Form
    {
        decimal total = 0;
        decimal i1000 = 0;
        decimal x500 = 0;
        decimal s100 = 0;
        decimal z50 = 0;
        decimal c10 = 0;
        decimal h5 = 0;
        decimal k1 = 0;
        public Form1()
        {
            InitializeComponent();
            Calculation();
        }
        public void Calculation()
        {
            decimal dish = numericUpDown1.Value * 30;
            decimal meat = numericUpDown2.Value * 40;
            decimal bean = numericUpDown3.Value * 15;
            decimal kelp = numericUpDown4.Value * 15;
            total = dish + meat + bean + kelp;
        }
        public void Change(decimal total)
        {
            for (; total >= 1000; total -= 1000)
            {
                i1000++;
            }
            if (total >= 500)
            {
                x500 = 1;
                total -= 500;
            }
            for (; total >= 100; total -= 100)
            {
                s100++;
            }
            if (total >= 50)
            {
                z50 = 1;
                total -= 50;
            }
            for (; total >= 10; total -= 10)
            {
                c10++;
            }
            if (total >= 5)
            {
                h5 = 1;
                total -= 5;
            }
            for (; total >= 1; total--)
            {
                k1++;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Calculation();
            Change(total);
            decimal i = numericUpDown3.Value * 2;
            decimal x = numericUpDown4.Value * 2;
            label5.Text = "點餐結果:\r\n\r\n";
            if (numericUpDown1.Value != 0)
            {
                label5.Text += "高麗菜" + numericUpDown1.Value + "份\r\n\r\n";
            }
            if (numericUpDown2.Value != 0)
            {
                label5.Text += "肉片" + numericUpDown2.Value + "份\r\n\r\n";
            }
            if (numericUpDown3.Value != 0)
            {
                label5.Text += "豆干" + i + "片\r\n\r\n";
            }
            if (numericUpDown4.Value != 0)
            {
                label5.Text += "海帶" + x + "片\r\n\r\n";
            }
            label5.Text += "金額一共" + total + "元\r\n\r\n";
            if (i1000 != 0)
            {
                label5.Text += "一千元" + i1000 + "張\r\n\r\n";
                i1000 = 0;
            }
            if (x500 != 0)
            {
                label5.Text += "五百元" + x500 + "張\r\n\r\n";
                x500 = 0;
            }
            if (s100 != 0)
            {
                label5.Text += "一百元" + s100 + "張\r\n\r\n";
                s100 = 0;
            }
            if (z50 != 0)
            {
                label5.Text += "五十元" + z50 + "個\r\n\r\n";
                z50 = 0;
            }
            if (c10 != 0)
            {
                label5.Text += "十元" + c10 + "個\r\n\r\n";
                c10 = 0;
            }
            if (h5 != 0)
            {
                label5.Text += "五元" + h5 + "個\r\n\r\n";
                h5 = 0;
            }
            if (k1 != 0)
            {
                label5.Text += "一元" + k1 + "個";
                k1 = 0;
            }
        }

    }
}
