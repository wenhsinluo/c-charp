using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Homework_9
{
    class Program
    {
        static void Main(string[] args)//數字轉大寫
        {
            Console.Write("請輸入整數數字:");
            string input = Console.ReadLine();
            string sinput = input.Replace("0", "零").Replace("1", "一").Replace("2", "二")
                .Replace("3", "三").Replace("4", "四").Replace("5", "五").Replace("6", "六")
                .Replace("7", "七").Replace("8", "八").Replace("9", "九");
            Console.WriteLine(sinput);
            Console.ReadKey();
        }
    }
}
