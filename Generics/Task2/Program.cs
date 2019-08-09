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
            int number;
            bool integer = false;

            do
            {
                Console.Write("Enter integer: ");
                integer = int.TryParse(Console.ReadLine(), out number);
            }
            while (!integer);

            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Compare<int, string> c = new Compare<int, string>();
            Data<int> i = new Data<int>();
            Data<string> s = new Data<string>();
            Data<bool> b = new Data<bool>();

            Console.WriteLine(i.Display(number));
            Console.WriteLine(s.Display(input));
            Console.WriteLine(b.Display(c.IsEquals(number, input)));
        }
    }

    class Data<T>
    {
        public string Display(T x)
        {
            return x.ToString();
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
