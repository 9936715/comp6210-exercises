using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task1
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

            while (q.Count != 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
