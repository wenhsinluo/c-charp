using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)//輸入民國年分判斷平潤年
        {
            while (true)
            {
                Console.WriteLine("請輸入民國年分:");
                int input = int.Parse(Console.ReadLine());
                input += 1911;
                if (input % 400 == 0)
                {
                    Console.WriteLine("該年為閏年");
                }
                else if (input % 4 == 0 && input % 100 != 0)
                {
                    Console.WriteLine("該年為閏年");
                }
                else
                {
                    Console.WriteLine("該年為平年");
                }
            }

        }
    }
}
