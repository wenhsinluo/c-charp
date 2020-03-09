using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = 0;
                int z = 0;
                int y = 2;
                Console.WriteLine("2張糖果紙可以換一顆糖,請輸入你想吃幾顆?:");
                int input = int.Parse(Console.ReadLine());
                while (true)
                {
                    a++; //買一次
                    input--;//吃一次
                    z++; //糖果紙加一張
                    if (z == y)
                    {
                        z = 0;
                        input--;
                        z++;
                    }
                    if (input <= 0)
                    {
                        break;
                    }
                }
                Console.WriteLine($"你只要買{a}顆!\r\n");
            }
        }
    }
}
