using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            int index = 0;
            string inputindex = "";

            var input = Console.ReadLine().ToLower().Split(',', '.', ' ');

            for (int x = 0; x <= input.Count() - 1; x++)
            {
                inputindex = input.ElementAt(x);
                index = 0;
                for (int y = 0; y <= input.Count() - 1; y++)
                {
                    if (inputindex==input.ElementAt(y))
                    {
                        index++;
                    }
                }
                try
                {
                    result.Add(inputindex, index);
                }
                catch
                {
                    break;
                }
            }
            foreach(var x in result)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
