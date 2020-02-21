using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Decimal input = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("您的收入:"+input);
                if (input <= 540000)
                {
                    input = input * 0.05m;
                }
                if (input > 540000 && input <= 1210000)
                {
                    input = input * 0.12m;

                    input -= 37800;
                }
                if (input > 1210000 && input <= 2420000)
                {
                    input = input * 0.2m;
                    input -= 134600;
                }
                if (input > 2420000 && input <= 4530000)
                {
                    input = input * 0.3m;
                    input -= 376600;
                }
                if (input > 4530000 && input <= 10310000)
                {
                    input = input * 0.4m;
                    input -= 829600;
                }
                if (input > 10310000)
                {
                    input = input * 0.5m;
                    input -= 1860600;
                }
                Console.WriteLine("應繳稅額"+ input);
                input = 0;
            }
        }
    }
}
