using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_max_value
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int result = 1;
                int max = int.Parse(Console.ReadLine());

                for (int x = 1; x < max; x++)
                {
                    if (x % 2 != 0)
                    {
                        int y = x + 1;

                        result -= y;
                    }
                    else
                    {
                        int y = x + 1;

                        result += y;
                    }

                }
                Console.WriteLine(result);
            }
        }
    }
}
