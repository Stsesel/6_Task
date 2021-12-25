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
            string OriginalString = Console.ReadLine();
            string[] stringArray  = OriginalString.Split();
            string reversedString = "";
            string str2 = "";




            foreach (string s in stringArray)
            {
                reversedString += s;

            }

            string str = reversedString.ToLower();


            Console.WriteLine(str);

            str2 = new string(str.Reverse().ToArray());

            Console.WriteLine (str2);

            if (str2==str)
            {
                Console.WriteLine("Предложение является палиндромом");
            }

            if (str2 != str)
            {
                Console.WriteLine("Предложение НЕ является палиндромом");
            }


            Console.ReadKey();



        }

    }
}
