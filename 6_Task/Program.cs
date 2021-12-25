using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int max = 0;
            string resultString = "";
            foreach(string s in stringArray)
            {
                if (s.Length > max)
                    max = s.Length;

                
            }

            foreach (string s in stringArray)
            {
                if (s.Length == max)
                    resultString = s;


            }


            Console.WriteLine("Количество символов {0}", max);
            Console.WriteLine("Самое длиное слово {0}", resultString);
            Console.ReadKey();
        }

    }
}
