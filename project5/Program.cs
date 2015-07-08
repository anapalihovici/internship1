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

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ana.palihovici\Documents\Visual Studio 2013\Projects\project5\project5\words.txt");

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
                //  Console.WriteLine("FIRST: " + first + " SECOND: " + second);
                // if (words.Contains(first) && words.Contains(second))
                while (anagram(second, words))
                
                {
                   
                   while (anagram(first, words))
                   {
                       Console.WriteLine("FIRST WORD: " + first);
                       Console.WriteLine("SECOND WORD: " + second);
                       found = true;
                   }
                }

            }

            if (!found) Console.WriteLine("Didn't find valid words");



            //Press any key to exit
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static Boolean anagram(string s, List<string> words)
        {
            //store letters in a list of chars
            char[] c = s.ToCharArray();
            List<char> letters = new List<char>();
            foreach (char ch in c)
            {
                letters.Add(ch);

            }


            for (var i = 0; i < words.Count; i++)
            {

                if (words[i].Length == s.Length)
                {
                    List<char> lettersCopy = new List<char>(letters);
                    char[] aux = words[i].ToCharArray();
                    int validLetters = 0;

                    for (int k = 0; k < aux.Length; k++)
                    {
                        if (lettersCopy.Contains(aux[k]))
                        {
                            validLetters++;
                            lettersCopy.Remove(aux[k]);
                        }


                    }
                    if (validLetters == s.Length)
                    {
                        Console.WriteLine("the word : " + words[i]); words.Remove(words[i]); return true; ;
                    }
                }

            }
            return false;
        }
    }
}

