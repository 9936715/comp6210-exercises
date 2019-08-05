using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Queue sorted = new Queue();

            q.Enqueue("Nigel");
            q.Enqueue("Makuini");
            q.Enqueue("Jerome");
            q.Enqueue("Makaio");
            q.Enqueue("Zane");

            string[] names = new string[q.Count];

            q.CopyTo(names, 0);

            Array.Sort(names);

            foreach(string s in names)
            {
                sorted.Enqueue(s);
            }

            Console.WriteLine("Sorted");
            while (sorted.Count != 0)
            {
                Console.WriteLine(sorted.Dequeue());
            }



        }
    }
}
