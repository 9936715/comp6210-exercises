using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2\n");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            string input;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter value: ");
                input = Console.ReadLine();
                dict.Add(i, input);
            }

            //Show dictionary

            Console.WriteLine("\nDictionary\n");

            foreach (KeyValuePair<int, string> k in dict)
            {
                Console.WriteLine($"Key: {k.Key}\tValue: {k.Value}");
            }

            // Search if value is in dictionary

            Console.WriteLine("");

            Console.Write("Search value: ");
            string search = Console.ReadLine();
            if (dict.ContainsValue(search))
            {
                Console.WriteLine($"'{search}' was found in the dictionary\n");
            }
            else
            {
                Console.WriteLine($"'{search}' was not found in the dictionary\n");
            }

        }
    }
}
