using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_3
{
    public partial class Form1 : Form
    {
        string y = "";
        string t = "";
        int[] random = new int[4];
        int[] play = new int[4];
        int k = 0;
        int A = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//開始按鈕
        {
            Random s = new Random();

            for (int i = 0; i <= 3; i++)
            {
                random[i] = s.Next(0, 10);

                for (int j = 0; j < i; j++)
                {
                    while (random[j] == random[i])
                    {
                        j = 0;
                        random[i] = s.Next(0, 10);
                    }
                }
            }
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)//看答案按鈕
        {
            t = "";
            foreach (int i in random)
            {
                t += i.ToString();
            }
            MessageBox.Show("" + t);
        }

        private void button3_Click(object sender, EventArgs e)//檢查答案
        {
            label3.Text = "請輸入4位數字!";
            if (textBox1.Text != "" && textBox1.Text.Count() == 4)
            {
                label3.Text = "";
                k = 0;
                A = 0;
                y = "";
                foreach (var u in textBox1.Text)
                {
                    play[k] = int.Parse(u.ToString());
                    y += u;
                    k++;
                }
                for (int i = 0; i < 4; i++)
                {
                    if (random[i] == play[i])
                    {
                        A++;
                    }
                }
                var ailist = new List<int> { random[0], random[1], random[2], random[3] };
                var playlist = new List<int> { play[0], play[1], play[2], play[3] };
                var intersection = ailist.Intersect(playlist);
                var B = intersection.Count();
                B -= A;
                textBox2.Text += textBox1.Text + "---" + A + "A" + B + "B" + "\r\n";
                if (A == 4)
                {
                    MessageBox.Show("恭喜過關!請重新開始!");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)//放棄重來
        {
            textBox1.Text = "";
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            y = "";
            t = "";
            random = new int[4];
            play = new int[4];
            k = 0;
            A = 0;
            textBox2.Text = "";
        }
    }
}
