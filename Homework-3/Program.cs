using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)//反轉以逗號隔開的文字
        {

            string end ="";

            Console.WriteLine("請輸入以逗號隔開的文字或數字:");
            string input = Console.ReadLine();
            char[] filter = { ',', '.', ' ' };                  //過濾器
            string[] array = input.Split(filter);               //切割完丟進文字陣列            
            Array.Reverse(array);                               //反轉整個陣列
            foreach (string array2 in array)                    //再個別取出取出
            {
                end += ($"{array2}");                           //個別塞入end
                end += ",";                                     //每塞一個加一個逗號 
            }
            Console.WriteLine(end.TrimEnd(','));                //去掉最後的逗號後呈現
            Console.ReadLine();

            //int[] array2 = Array.ConvertAll(array, int.Parse);//string型別轉換int  (沒必要了)
        }
    }
}
