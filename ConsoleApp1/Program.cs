using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The,dog, had, a, bone, a ,ball, and other toys.";
            char[] charsToTrim = { ',', '.', ' ' };
            string[] words = sentence.Split(charsToTrim);
            foreach (string word in words)
                Console.WriteLine(word.TrimEnd(charsToTrim));
                Console.ReadLine();

            // The example displays the following output:
            //       The
            //       dog
            //       had
            //       a
            //       bone
            //       a
            //       ball
            //       and
            //       other
            //       toys

        }
    }
}
