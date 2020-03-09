using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Single_and_double_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入逗號隔開的正整數!\r\n");
                string _s2 = "", _d2 = "";
                List<string> input = Console.ReadLine().Split(',', '.', ' ').ToList();
                input.Sort();
                List<int> input2 = input.ConvertAll<int>(x => Convert.ToInt32(x));
                var _single = input2.Where(x => x % 2 != 0);
                var _double = input2.Where(x => x % 2 == 0);
                foreach (var x in _single)
                {
                    _s2 += x + ",";
                }
                foreach (var x in _double)
                {
                    _d2 += x + ",";
                }
                Console.WriteLine($"奇數:{_s2.Trim(',', '.', ' ')}\r\n偶數:{_d2.Trim(',', '.', ' ')}\r\n");
            }
            var s = Console.ReadLine();
            var result = s.Split(',')
                .Select(x => int.Parse(x))
                .OrderBy(x => x)
                .GroupBy(x => (x % 2))
                .OrderByDescending(x => x.Key)
                .Select(x => $"{(x.Key == 1 ? "奇數" : "偶數")} : {string.Join(",", x)}");

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
