using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)//輸入數字判斷奇偶數
        {
            while (true) //方便重複使用
            {
                int value;
                int Remaining;

                Console.WriteLine("請輸入判斷數字");
                string input = Console.ReadLine();
                value = int.Parse(input);         //輸入的字串轉換int型別
                Remaining = value % 2;            //轉換後取商數


                if (Remaining == 0)//商數等於0代表偶數
                {
                    Console.WriteLine("你輸入的是偶數" + "\r\n");
                }
                else//不是就表示是奇數
                {
                    Console.WriteLine("你輸入的是奇數" + "\r\n");
                }
            }






        }

    }
}
