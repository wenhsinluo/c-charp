using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入大於90的正整數!");
            int input = int.Parse(Console.ReadLine());
            for (int x = 1; x <= input; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if(x % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if(x % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
