using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon2_2
{
    public partial class Form1 : Form
    {
        List<TC> tclist = new List<TC>();
        TC CT = new TC { TCname = "中華電信", Monthly_fee = 350, Minute_fee = 4, Total = 0 };
        TC FT = new TC { TCname = "遠傳電信", Monthly_fee = 400, Minute_fee = 3, Total = 0 };
        TC TT = new TC { TCname = "台灣電信", Monthly_fee = 500, Minute_fee = 2, Total = 0 };


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                tclist.Clear();
                label3.Text = "";

                int input = int.Parse(textBox1.Text);

                TC.BestPrices(CT, input);
                TC.BestPrices(FT, input);
                TC.BestPrices(TT, input);
                tclist.Add(CT);
                tclist.Add(FT);
                tclist.Add(TT);
                var top = tclist.Where(x => x.Total == tclist.Min(c => c.Total));

                foreach (var item in top)
                {
                    label3.Text += item.TCname + item.Total + "\r\n";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
