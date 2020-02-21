using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 101;//初始值
            int b = 200;//上限值
            int c = 100;//幾個質數

            for (int i = a; i <= b; i++)
            {
                
                for (int x = 2; x < i; x++)
                {
                    if(i == x+1)
                    {
                        Console.WriteLine(i.ToString());
                    }
                    if (i % x == 0)
                    {
                        c--;
                        break;
                    }
                }
            }
            Console.WriteLine(c+"個質數");
            Console.ReadLine();
        }
    }
}
