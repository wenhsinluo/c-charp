using Hackathon2_5.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2_5
{
    class Program
    {

        static string fileName;
        static void Main(string[] args)
        {
            Database1Table data = new Database1Table();
            List<Database1Table> data2 = new List<Database1Table>();
            fileName = "test03.txt";
            var test = File.ReadAllLines(fileName);
            var list = new List<string>();

            foreach (var x in test)
            {
                if (x.StartsWith("695") || x.StartsWith("525"))
                {
                    data = new Database1Table { 
                        TickNumber = x.Substring(0, 12),
                        FlyingDay = DateTime.ParseExact(x.Substring(13, 8), "yyyyMMdd", null),
                        Birthday = DateTime.ParseExact(x.Substring(21, 8), "yyyyMMdd", null)
                    };

                    data2.Add(data);
                }
            }
            
            Console.ReadLine();
        }
    }
}
//($"TickNumber:{x.Substring(0, 12)},FlyingDay:{x.Substring(13, 8)},Birthday:{x.Substring(21, 8)}");
