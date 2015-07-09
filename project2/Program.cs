//problema  9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{

    struct employee { public string first_name; public string family_name;};

    public class Program
    {
        static void Main(string[] args)
        {

            employee[] arr = new employee[100];
            // int[] arrMyValues = new int[] { 1, 2, 3 };
            List<int> employee_nr = new List<int>();
            Random rnd = new Random();
            int i = 0, r;

            // Read the text file line by line and store from each line the first name and the family name
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ana.palihovici\Documents\Visual Studio 2013\Projects\project2\project2\employees.txt");

            System.Console.WriteLine("Employees:");
            foreach (string line in lines)
            {
                i++;
                System.Console.WriteLine("Number of Employees: " + i);
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
                string[] words;
                words = line.Split(' ');
                arr[i].first_name = words[0];
                arr[i].family_name = words[1];
                employee_nr.Add(i);

            }

            //after we have read all employees we assign each of them a Secret Santa

            for (int k = 1; k <= i; k++)
            {

                do
                { r = rnd.Next(employee_nr.Count); }
                while (employee_nr[r] == k || !(employee_nr.Contains(r)));

                Console.WriteLine("\t" + arr[k].first_name + " " + arr[k].family_name + " has been assigned: " + arr[employee_nr[r]].first_name + " " + arr[employee_nr[r]].family_name);

                employee_nr.Remove(employee_nr[r]);

            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

    }
}
