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
            string number;
            for(int i = 0;i <= 100; i++)
            {
                number = i.ToString().Replace("0", "D").Replace("3", "A").Replace("5", "B").Replace("9", "C");
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
