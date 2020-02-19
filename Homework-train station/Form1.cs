using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Homework_train_station
{
    public partial class Form1 : Form
    {

        double i = 0;
        List<string> station = new List<string> { "起站" };
        List<string> station2 = new List<string> { "訖站" };

        public void Comboboxupdata()
        {
            comboBox1.DataSource = null;
            comboBox2.DataSource = null;
            comboBox1.DataSource = station;
            comboBox2.DataSource = station2;
        }
        public Form1()
        {
            InitializeComponent();
            Comboboxupdata();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> station3 = new List<string> {(string)comboBox1.SelectedItem,(string)comboBox2.SelectedItem };
            if (station3.Contains("台北") && station3.Contains("新竹"))
            {
                i = 177;
            }
            if (station3.Contains("台北") && station3.Contains("台中"))
            {
                i = 375;
            }
            if (station3.Contains("台北") && station3.Contains("嘉義"))
            {
                i = 598;
            }
            if (station3.Contains("台北") && station3.Contains("台南"))
            {
                i = 738;
            }
            if (station3.Contains("台北") && station3.Contains("高雄"))
            {
                i = 842;
            }
            if (station3.Contains("新竹") && station3.Contains("台中"))
            {
                i = 197;
            }
            if (station3.Contains("新竹") && station3.Contains("嘉義"))
            {
                i = 421;
            }
            if (station3.Contains("新竹") && station3.Contains("台南"))
            {
                i = 560;
            }
            if (station3.Contains("新竹") && station3.Contains("高雄"))
            {
                i = 755;
            }
            if (station3.Contains("台中") && station3.Contains("嘉義"))
            {
                i = 224;
            }
            if (station3.Contains("台中") && station3.Contains("台南"))
            {
                i = 363;
            }
            if (station3.Contains("台中") && station3.Contains("高雄"))
            {
                i = 469;
            }
            if (station3.Contains("嘉義") && station3.Contains("台南"))
            {
                i = 139;
            }
            if (station3.Contains("嘉義") && station3.Contains("高雄"))
            {
                i = 245;
            }
            if (station3.Contains("台南") && station3.Contains("高雄"))
            {
                i = 106;
            }
            if (checkBox1.Checked == true)
            {
                i = i * 2;
                i = i * 0.9;
            }
            if (checkBox2.Checked == true)
            {
                i = i * 0.9;
            }
            decimal s = Convert.ToInt16(Math.Ceiling(i));
            label1.Text = $"票價:{s}元";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                station.Clear();
                station.AddRange(new string[] { "台北", "新竹", "台中", "嘉義", "台南" });
                Comboboxupdata();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                station.Clear();
                station.AddRange(new string[] { "新竹", "台中", "嘉義", "台南", "高雄" });
                Comboboxupdata();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "台北" && radioButton1.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "新竹", "台中", "嘉義", "台南", "高雄" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "新竹" && radioButton1.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "台中", "嘉義", "台南", "高雄" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "台中" && radioButton1.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "嘉義", "台南", "高雄" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "嘉義" && radioButton1.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "台南", "高雄" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "台南" && radioButton1.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "高雄" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "高雄" && radioButton2.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "台北", "新竹", "台中", "嘉義", "台南" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "台南" && radioButton2.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "台北", "新竹", "台中", "嘉義" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "嘉義" && radioButton2.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "台北", "新竹", "台中" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "台中" && radioButton2.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "台北", "新竹" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }
            if (comboBox1.Text == "新竹" && radioButton2.Checked == true)
            {
                station2.Clear();
                station2.AddRange(new string[] { "台北" });
                comboBox2.DataSource = null;
                comboBox2.DataSource = station2;
            }

        }
    }
}
