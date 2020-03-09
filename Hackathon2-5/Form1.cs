using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon2_5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Database1Table' 資料表。您可以視需要進行移動或移除。
            this.database1TableTableAdapter1.Fill(this.database1DataSet1.Database1Table);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.Database1Table' 資料表。您可以視需要進行移動或移除。
            this.database1TableTableAdapter.Fill(this.database1DataSet.Database1Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
