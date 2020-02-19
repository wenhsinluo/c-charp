using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homework_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(int.Parse(inputTextbox.Text), 1, 1);
            DateTime date2 = new DateTime(int.Parse(inputTextbox.Text), 1, 1);
            int l;
            int Sunday = 0;
            int Saturday = 0;
            int s = 1;
            bool R = DateTime.IsLeapYear(int.Parse(inputTextbox.Text));
            if (R)
            {
                for (int x = 0; x <= 365; x++)
                {
                    l = (int)date2.DayOfWeek;
                    if (l == 0)
                    {
                        Sunday += 1;
                    }
                    else if (l == 6)
                    {
                        Saturday += 1;
                    }
                    date2 = date.AddDays(s++);
                }
                EndLabel.Text = "星期六有:" + Saturday + "天" + "\r\n" + "星期天有:" + Sunday + "天";
            }
            else
            {
                for (int x = 0; x <= 364; x++)
                {
                    l = (int)date2.DayOfWeek;
                    if (l == 0)
                    {
                        Sunday += 1;
                    }
                    else if (l == 6)
                    {
                        Saturday += 1;
                    }
                    date2 = date.AddDays(s++);
                }
                EndLabel.Text = "星期六有:" + Saturday + "天" + "\r\n" + "星期天有:" + Sunday + "天";
            }
        }
    }
}
