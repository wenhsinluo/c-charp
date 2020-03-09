using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)//輸入數字判斷奇偶數
        {
            string TickNumber = string.Empty;
            DateTime FlyingDay, Birthday;
            List<string> list = new List<string>();
            List<string> result = new List<string>();
            var lines = File.ReadAllLines("test03.TXT");
            var res = lines.ToList().Where(x => x.StartsWith("695") || x.StartsWith("525"));
            foreach (var item in res)
            {
                if (DateTime.TryParseExact(item.Substring(13, 8), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime r1) &&
                    DateTime.TryParseExact(item.Substring(21, 8), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime r2) ||
                    int.Parse(item.Substring(13, 8)) == 99999999) //符合日期格式
                {
                    result.Add(item);
                }
            }
            foreach (var item in result)
            {
                TickNumber = item.Substring(0, 13);
                Console.WriteLine($"TickNumber: {TickNumber}");
            }
            foreach (var item in result)
            {
                DateTime.TryParseExact(item.Substring(13, 8), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out FlyingDay);
                if (item.Substring(13, 8) == "99999999")
                {
                    FlyingDay = DateTime.MaxValue;
                }
                Console.WriteLine($"FlyingDay: {FlyingDay}");
            }
            foreach (var item in result)
            {
                DateTime.TryParseExact(item.Substring(21, 8), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out Birthday);
                Console.WriteLine($"Birthday: {Birthday}");
            }
            Console.ReadLine();
        }
    }

    
}
