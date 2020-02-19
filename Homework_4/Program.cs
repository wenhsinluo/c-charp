using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = "";
            Console.Write("請輸入整數:");
            int input = int.Parse(Console.ReadLine());//疊數字
            int input2 = input;
            for (int i = 1; i <= input2; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    end += ($"{input}");
                }
                end += "\r\n";
                input -= 1;
            }
            Console.WriteLine(end);
            Console.ReadLine();
        }
    }
}
