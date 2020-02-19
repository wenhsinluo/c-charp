using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luwei_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ans = new banknote(6666);
            MessageBox.Show($"1000={ans.m1000}張\r\n500={ans.m500}張\r\n100={ans.m100}張\r\n50={ans.m50}張\r\n10={ans.m10}張\r\n5={ans.m5}張\r\n1={ans.m1}張\r\n");
        }
    }
}
