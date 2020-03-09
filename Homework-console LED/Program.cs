using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_console_LED
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str1 = "", str2 = "", str3 = "";
                Console.WriteLine("請輸入正整數!");
                string Preset = "0123456789";
                string input = Console.ReadLine();
                for (int x = 0; x <= input.Count() - 1; x++)
                {
                    if (input.ElementAt(x) == Preset.ElementAt(0))
                    {
                        str1 += " _ ";
                        str2 += "| |";
                        str3 += "|_|";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(1))
                    {
                        str1 += "   ";
                        str2 += "  |";
                        str3 += "  |";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(2))
                    {
                        str1 += " _ ";
                        str2 += " _|";
                        str3 += "|_ ";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(3))
                    {
                        str1 += " _ ";
                        str2 += " _|";
                        str3 += " _|";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(4))
                    {
                        str1 += "   ";
                        str2 += "|_|";
                        str3 += "  |";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(5))
                    {
                        str1 += " _ ";
                        str2 += "|_ ";
                        str3 += " _|";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(6))
                    {
                        str1 += " _ ";
                        str2 += "|_ ";
                        str3 += "|_|";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(7))
                    {
                        str1 += " _ ";
                        str2 += "| |";
                        str3 += "  |";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(8))
                    {
                        str1 += " _ ";
                        str2 += "|_|";
                        str3 += "|_|";
                    }
                    if (input.ElementAt(x) == Preset.ElementAt(9))
                    {
                        str1 += " _ ";
                        str2 += "|_|";
                        str3 += " _|";
                    }
                }
                Console.WriteLine(str1 + "\r\n" + str2 + "\r\n" + str3 + "\r\n");
            }
        }
    }
}
