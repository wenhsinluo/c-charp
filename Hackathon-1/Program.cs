using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x <= 100; x++)
            {
                Console.WriteLine(x.ToString().Replace("3", "A").Replace("5", "B").Replace("9", "C").Replace("0", "D"));
            }
            Console.ReadLine();
        }
    }

}
