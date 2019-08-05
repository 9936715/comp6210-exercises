using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue("Nigel");
            q.Enqueue("Makuini");
            q.Enqueue("Jerome");
            q.Enqueue("Makaio");
            q.Enqueue("Zane");

            // Check to see if name is in queue
            Console.Write("Enter a name to search: ");
            string input = Console.ReadLine();

            if (q.Contains(input))
            {
                Console.WriteLine("Name is in the queue");
            }
            else
            {
                Console.WriteLine("Name is not found");
            }
        }
    }
}
