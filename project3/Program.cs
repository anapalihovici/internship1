//Problem 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, result;
            Console.Write("Please give the number to be converted : ");
            s = Console.ReadLine();
            int nr = Convert.ToInt32(s);
            result = convert(nr);
            Console.WriteLine("The converted roman number is : " + result);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        public static string convert(int nr)
        {

            int[] arabic_numbers = new int[] { 1000, 990, 900, 500, 490, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] roman_numbers = new string[] { "M", "XM", "CM", "D", "XD", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string converted = "";
            int i = 0;
            while (nr > 0 || arabic_numbers.Length == (i - 1))
            {
                while (nr >= arabic_numbers[i])
                {
                    nr = nr - arabic_numbers[i];
                    converted = converted + roman_numbers[i];
                }
                i++;
            }
            return converted;
        }
    }
}
