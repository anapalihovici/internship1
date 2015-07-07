using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Boolean found = false;
            char[] word = new char[30];
            char[] word1 = new char[30];
            char[] word2 = new char[30];

            List<string> words = new List<string>();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ana.palihovici\Documents\Visual Studio 2013\Projects\project5\project5\new.txt");

            foreach (string line in lines)
            {
                words.Add(line);
            }

            Console.Write("Word : ");
            input = Console.ReadLine();

            word = input.ToCharArray();

            for (int i = 1; i < word.Length; i++)
            {
                string first = new string(word.Skip(0).Take(i).ToArray());
                string second = new string(word.Skip(i).Take(word.Length - i).ToArray());
                Console.WriteLine("FIRST: " + first + " SECOND: " + second);
                if (words.Contains(first) && words.Contains(second))
                { if (anagram(first, words)&& anagram(second, words)) { Console.WriteLine("FIRST: " + first + " SECOND: " + second); found = true; } }

            }

            if (!found) Console.WriteLine("Didn't find valid words");



            //Press any key to exit
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static Boolean anagram(string s, List<string> words)
        {
            Console.WriteLine("Valid word: "+s);
            //store letters in a list of chars
            char[] c = s.ToCharArray();
            List<char> letters = new List<char>();
            foreach (char ch in c)
            {
                letters.Add(ch);

            }


            for (var i = 0; i < words.Count; i++) {
             
                if (words[i].Length == s.Length)
                {
                    Console.WriteLine("Same length: "+ words[i]+" "+s);
                    char[] aux = words[i].ToCharArray();
                    int ok=0;
                    
                    string aux2 = new string(aux);
                   
                    for (int j = 0; j < aux.Length; j++)
                    {

                        if (!letters.Contains(aux[j]))
                        {
                            Console.WriteLine("length of aux : "+aux.Length);
                            ok++;
                            return false;
                           
                        }
                        if (ok == s.Length) { Console.WriteLine("Found anagram: " + words[i]); return true; }

                    }
                 
                }      
           
               }
        return false;
        }
    }
}

