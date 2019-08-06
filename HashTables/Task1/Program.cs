using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an application that uses a loop to populate a dictionary using the loop counter as the key and names input by the user as the values, then display those names back to the user.

            Console.WriteLine("Task 1\n");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            string input;

            // Get values for dictionary

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter value: ");
                input = Console.ReadLine();
                dict.Add(i, input);
            }

            // Show dictionary

            Console.WriteLine("\nDictionary\n");

            foreach(KeyValuePair<int, string> k in dict)
            {
                Console.WriteLine($"Key: {k.Key}\tValue: {k.Value}");
            }

            Console.WriteLine();
        }
    }
}
