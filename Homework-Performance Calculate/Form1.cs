using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Performance_Calculate
{
    public partial class Form1 : Form
    {
        List<Company> saleslist;
        List<Stationery> priceslist;


        public Form1()
        {
            InitializeComponent();
            CreateList();
            
        }

        public void CreateList()
        {
            saleslist = new List<Company>();
            saleslist.Add(new Company() { Salesname = "Bill", SalesList = new Dictionary<string, int>() { { "原子筆", 33 }, { "鉛筆", 32 }, { "橡皮擦", 56 }, { "直尺", 45 }, { "立可白", 33 } } });
            saleslist.Add(new Company() { Salesname = "John", SalesList = new Dictionary<string, int>() { { "原子筆", 77 }, { "鉛筆", 33 }, { "橡皮擦", 33 }, { "直尺", 45 }, { "立可白", 23 } } });
            saleslist.Add(new Company() { Salesname = "David", SalesList = new Dictionary<string, int>() { { "原子筆", 43 }, { "鉛筆", 55 }, { "橡皮擦", 43 }, { "直尺", 67 }, { "立可白", 65 } } });

            priceslist = new List<Stationery>();
            priceslist.Add(new Stationery() { Stationeryname = "原子筆", Stationeryprices = 12 });
            priceslist.Add(new Stationery() { Stationeryname = "鉛筆", Stationeryprices = 16 });
            priceslist.Add(new Stationery() { Stationeryname = "橡皮擦", Stationeryprices = 10 });
            priceslist.Add(new Stationery() { Stationeryname = "直尺", Stationeryprices = 14 });
            priceslist.Add(new Stationery() { Stationeryname = "立可白", Stationeryprices = 15 });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
