using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            string z = "1\r\n1\r\n";
            Queue<int> MyQueue;
            MyQueue = new Queue<int>();
            {
                MyQueue.Enqueue(1);
                MyQueue.Enqueue(1);
            };

            for (int i = 1; i < 1836311903;)
            {
                foreach (int x in MyQueue)
                {
                    y += x;
                }
                z += y + "\r\n";
                MyQueue.Dequeue();
                MyQueue.Enqueue(y);
                i = y;
                y = 0;
            }
            Console.WriteLine(z.TrimEnd(','));
            Console.ReadLine();
        }
    }
}
