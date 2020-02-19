using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Parking
{
    public partial class Form1 : Form
    {
        double pay;
        double quotient;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var time = dateTimePicker2.Value - dateTimePicker1.Value;

            if (time.TotalMinutes >= 240)
            {
                quotient = time.TotalMinutes % 30;
                pay = (((time.TotalMinutes-quotient) / 30) * 60)-200;
            }
            else if (time.TotalMinutes <= 239 && time.TotalMinutes >= 121)
            {
                quotient = time.TotalMinutes % 30;
                pay = (((time.TotalMinutes - quotient) / 30) * 40)-40;
            }
            else
            {
                quotient = time.TotalMinutes % 30;
                pay = ((time.TotalMinutes - quotient) / 30) * 30;
            }

            MessageBox.Show("停車費一共是:" + pay+"元!");
        }
    }
}
