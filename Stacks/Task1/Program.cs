using System;
using System.Collections;
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
            /*
             * Create an application that uses a stack to store the values input by the user. Your application needs to check if the stack contains a specific value and if it does remove all of the elements above it but leave the value searched for and all other values below in the stack.
             */

            // Create stack
            int size = 10;
            Stack stack = new Stack(size);
            string input = "";
            Stack temp = new Stack();

            // Get value from user
            Console.WriteLine("Type exit to end");

            for(int i=0; i<size; i++)
            {
                Console.Write("\nInput value: ");
                input = Console.ReadLine();

                if (stack.Contains(input))
                {
                    while(input!=(string)stack.Peek())
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(input);
                }
                
                // Show stack

                Console.WriteLine("Current Stack:");
                temp.Clear();
                temp = (Stack)stack.Clone();

                while (temp.Count != 0)
                {
                    Console.WriteLine(temp.Pop());
                }
            }

            Console.WriteLine();
        }
    }
}
