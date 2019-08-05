using System;
using System.Collections;
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
            int input;
            bool parse;
            Stack stack = new Stack();
            Stack temp = new Stack();
            Stack temp2 = new Stack();

            Console.WriteLine("To exit entering integers, enter a non integer\n");
            while (true)
            {
                Console.Write("Enter an integer: ");
                parse = int.TryParse(Console.ReadLine(), out input);
                if (parse)
                {
                    stack.Push(input);
                }
                else
                {
                    break;
                }
            }

            //Show stack reversed

            temp = (Stack)stack.Clone();

            Console.WriteLine("\nReverse Order\n-------------");
            while(temp.Count != 0)
            {
                Console.WriteLine(temp.Peek());
                temp2.Push(temp.Pop());
            }

            //Console.WriteLine("\nReverse Stack\n-------------");
            //while(temp2.Count !=0)
            //{
            //    Console.WriteLine(temp2.Pop());
            //}

            Console.WriteLine();
        }
    }
}
