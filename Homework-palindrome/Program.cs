using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_palindrome
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (Judge(input))
                {
                    Console.WriteLine("是迴文");
                }
                else
                {
                    Console.WriteLine("不是迴文");
                }
            }
        }
        static bool Judge(string input)
        {
            for (int x = 0; x <= input.Count() / 2; x++)
            {
                int y = input.Count();
                if (input.ElementAt(x) != input.ElementAt((y - x) - 1))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
