using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)//輸入逗號隔開的數字 判斷奇偶數並分開陳列
        {

            string _double = "";
            string _single = "";
            int input3 ;
            int input4 ;

            Console.WriteLine("請輸入以逗號或空白隔開的數字:");
            string input = Console.ReadLine();                                 //將輸入字串指派给input
            input = input.TrimEnd(',');                                        //避免使用者輸入逗號(,)在最後造成BUG無法順利執行
            char[] filter = { ',', '.', ' ' };                                 //用char陣列過濾","."空白鍵"將切割條件指派給filter
            string[] array1 = input.Split(filter);                             //將input字串用split切割並加入filter(切割條件)後指派給字串陣列array1
            Array.Sort(array1);                                                //用 Array.Sort將array1內的數字(字元?)小到大排序
            foreach (string input2 in array1)                                  //把排序好的數字用foreach一個一個挑出來
            {
                input3 = int.Parse(input2);                                    //每挑出一個就先轉成int型別
                input4 = input3 % 2;                                           //轉成int後就可以做計算了,將取出的數字再取出商數
                if (input4 == 0)                                               //如果商數等於零代表偶數,進入此區塊
                {
                    _double += ($"{input3}");                                  //直接把剛剛挑出來的數字放入_double字串
                    _double += ",";                                            //並在最後加入字串逗號
                }
                if (input4 > 0)                                                //如果商數大於零代表奇數,進入此區塊
                {
                    _single += ($"{input3}");                                  //直接把剛剛挑出來的數字放入_Single字串
                    _single += ",";                                            //並在最後加入字串逗號
                }
            }
            Console.WriteLine($"你輸入的單數:{_single.TrimEnd(',')}");
            Console.WriteLine($"你輸入的雙數:{_double.TrimEnd(',')}");          //把產生的最後一個逗號消除            
            Console.ReadLine();            //^^^^^^^^^^^^^^^^^^^^.TrimEnd(最後一個如果是逗號(,)就消除)
        }
    }
}
