using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int convertedSt;
            char[] arr;
            int number = 0;

            Console.Write("Please write string to be converted: ");
            arr = Console.ReadLine().ToCharArray();
           

            for (int i = 0; i < arr.Length; i++)
            {
                convertedSt = convert(arr[i]);
                //Console.WriteLine("Converted: " + convertedSt);
                number = number * 10 + convertedSt;
            }


            System.Console.WriteLine("Resulted number: "+ number);

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
        //
        private static int convert(char ch)
        {   
            switch(ch){
                    case '0' : return 0;
                    case '1' : return 1;
                    case '2' : return 3;
                    case '3' : return 3;
                    case '4' : return 4;
                    case '5' : return 5;
                    case '6' : return 6;
                    case '7' : return 7;
                    case '8' : return 8;
                    case '9' : return 9;
            
                default : return 0;
            }
 
        }
    }
}
