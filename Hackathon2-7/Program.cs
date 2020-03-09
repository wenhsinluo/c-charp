using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;
            List<int> list = new List<int>();
            for (int z = 1; z <= 100; z++)
            {
                list.Add(z);
            }

            for (x = 1; list.Count() > 1; x++) //y = index , x = 每三次踢一次的計數器
            {
                y++;  

                if(x == 3)
                {
                    x = 0;
                    y--;

                    if (y > list.Count() - 1)
                    {
                        y %= list.Count();
                    }
                    
                    list.RemoveAt(y);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
