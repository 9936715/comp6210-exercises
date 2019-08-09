using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an application that will ask the user for a number and a string and save them to appropriate variables. You then need to create a generic method that will check if the number and the string are the same or not and display the result to the user.

            int number;
            bool integer = false;

            do
            {
                Console.Write("Enter integer: ");
                integer = int.TryParse(Console.ReadLine(),out number);
            }
            while (!integer);

            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Compare<int, string> c = new Compare<int, string>();

            Console.WriteLine($"Values are equal: {c.IsEquals(number, input).ToString()}");
        }
    }

    class Compare<T, U>
    {
        public bool IsEquals(T x, U y)
        {
            if (x.ToString().Equals(y.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
