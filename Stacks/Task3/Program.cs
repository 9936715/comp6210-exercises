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
            Stack stack = new Stack();
            
            string input = Console.ReadLine();

            foreach(char c in input)
            {
                stack.Push(c);
            }

            while(stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
