using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 3\n");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            string input;

            // Get values for dictionary

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter value: ");
                input = Console.ReadLine();
                dict.Add(i, input);
            }

            // Copy to array and show

            string[] arr = new string[dict.Count];

            dict.Values.CopyTo(arr, 0);

            Console.WriteLine("\nArray\n");

            foreach(string s in arr)
            {
                Console.WriteLine($"Value: {s}");
            }

            Console.WriteLine();
        }
    }
}
