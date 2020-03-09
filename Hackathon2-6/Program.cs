using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            for (int x = 0; x <= 100; x++)
            {
                for (int y = 0; y <= 100; y++)
                {
                    for (int z = 0; z <= 100; z++)
                    {
                        loop++;
                        Console.WriteLine($"公雞{x},母雞{y},小雞{z}");
                        if ((x + y + z == 100) && (60 * x + 30 * y + z == 1000))
                        {
                            Console.WriteLine($"公雞{x},母雞{y},小雞{z},共跑了{loop}圈");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
