using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Performance_Calculate
{
    public class Company
    {
        public string Salesname { get; set; }

        public Dictionary<string, int> SalesList { get; set; }
        //public int Eraser { get; set; } //橡皮擦 10

        //public int Ballpointpen { get; set; }//原子筆 12

        //public int Ruler { get; set; }//直尺 14

        //public int Correctionfluid { get; set; }//立可白 15

        //public int Pencil { get; set; }//鉛筆 16
    }

    public class Stationery
    {
        public string Stationeryname { get; set; }

        public decimal Stationeryprices { get; set; }
        //public int EraserPrices { get; set; }
        //public int BallpointpenPrices { get; set; }
        //public int RulerPrices { get; set; }
        //public int CorrectionfluidPrices { get; set; }
        //public int PencilPrices { get; set; }
    }
}
