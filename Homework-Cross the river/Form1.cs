using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Cross_the_river
{
    public partial class Form1 : Form
    {
        private List<string> Leftlist;
        private List<string> Rightlist;

        public Form1()
        {
            InitializeComponent();
            Createplayrs();
            Createplist();
            Uptextdata();
            Setlistboxdatasource();
        }
        private List<string> Createplayrs()
        {
            return new List<string>
            {
                "農夫",
                "野狼",
                "綿羊",
                "蔬菜"
            };
        }
        private void Createplist()
        {
            Leftlist = Createplayrs();
            Rightlist = new List<string>();
        }
        private void Judge()
        {
            if (Rightlist.Count() == 3 && Rightlist.Contains("野狼") && Rightlist.Contains("綿羊") && Rightlist.Contains("蔬菜"))
            {
                MessageBox.Show("狼咬著羊,羊咬著菜" + "\r\n" + "請重新開始!");
                Createplist();
                Uptextdata();
            }
            if (Leftlist.Count() == 3 && Leftlist.Contains("野狼") && Leftlist.Contains("綿羊")&&Leftlist.Contains("蔬菜"))
            {
                MessageBox.Show("狼咬著羊,羊咬著菜" + "\r\n" + "請重新開始!");
                Createplist();
                Uptextdata();
            }
            if (Leftlist.Count() == 2 && Leftlist.Contains("野狼") && Leftlist.Contains("綿羊"))
            {
                MessageBox.Show("綿羊已被野狼吃掉" + "\r\n" + "請重新開始!");
                Createplist();
                Uptextdata();
            }
            if (Leftlist.Count() == 2 && Leftlist.Contains("蔬菜") && Leftlist.Contains("綿羊"))
            {
                MessageBox.Show("蔬菜已被綿羊吃掉" + "\r\n" + "請重新開始!");
                Createplist();
                Uptextdata();
            }
            if (Rightlist.Count() == 2 && Rightlist.Contains("野狼") && Rightlist.Contains("綿羊"))
            {
                MessageBox.Show("綿羊已被野狼吃掉" + "\r\n" + "請重新開始!");
                Createplist();
                Uptextdata();
            }
            if (Rightlist.Count() == 2 && Rightlist.Contains("蔬菜") && Rightlist.Contains("綿羊"))
            {
                MessageBox.Show("蔬菜已被綿羊吃掉" + "\r\n" + "請重新開始!");
                Createplist();
                Uptextdata();
            }
            if (Rightlist.Count() == 4)
            {
                MessageBox.Show("恭喜過關了!");
                Createplist();
                Uptextdata();
            }
        }
        private void Uptextdata()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = Leftlist;
            listBox2.DataSource = Rightlist;
        }
        private void Setlistboxdatasource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//左到右
        {
            if (listBox1.SelectedItem != null && Leftlist.Contains("農夫") && (string)listBox1.SelectedItem != "農夫")
            {
                string item = (string)listBox1.SelectedItem;
                Leftlist.Remove(item);
                Leftlist.Remove("農夫");
                Rightlist.Add(item);
                Rightlist.Add("農夫");
                Uptextdata();
                Judge();
            }
            else if ((string)listBox1.SelectedItem == "農夫")
            {
                Leftlist.Remove("農夫");
                Rightlist.Add("農夫");
                Uptextdata();
                Judge();
            }

        }

        private void button2_Click(object sender, EventArgs e)//右到左
        {
            if (listBox2.SelectedItem != null && Rightlist.Contains("農夫") && (string)listBox2.SelectedItem != "農夫")
            {
                string item = (string)listBox2.SelectedItem;
                Rightlist.Remove(item);
                Rightlist.Remove("農夫");
                Leftlist.Add(item);
                Leftlist.Add("農夫");
                Uptextdata();
                Judge();
            }
            else if ((string)listBox2.SelectedItem == "農夫")
            {
                Rightlist.Remove("農夫");
                Leftlist.Add("農夫");
                Uptextdata();
                Judge();
            }
        }
    }
}
