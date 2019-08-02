using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=50");

            List<Person> Persons = new JavaScriptSerializer().Deserialize<List<Person>>(json);

            List<Person> Females = new List<Person>();
            List<Person> Males = new List<Person>();

            foreach (Person p in Persons)
            {
                if (p.gender == "female")
                {
                    Females.Add(p);
                }
                else
                {
                    Males.Add(p);
                }
            }

            /*
             
            string[] females = Females.Select(f => f.name).ToArray();
            Array.Sort(females);
            
            */

            List<Person> SortedFemales = Females.OrderBy(f => f.surname).ToList();
            List<Person> SortedMales = Males.OrderBy(m => m.surname).ToList();

            int maxMaleAge = Males.Max(f => f.age);
            int minMaleAge = Males.Min(f => f.age);
            double averageMaleAge = Males.Average(f => f.age);

            Console.WriteLine("-----\nMales\n-----\n");
            DisplayAges(maxMaleAge, minMaleAge, averageMaleAge);
            ShowList(SortedMales);

            int maxFemaleAge = Females.Max(f => f.age);
            int minFemaleAge = Females.Min(f => f.age);
            double averageFemaleAge = Females.Average(f => f.age);

            Console.WriteLine("-------\nFemales\n-------\n");

            DisplayAges(maxFemaleAge, minFemaleAge, averageFemaleAge);
            ShowList(SortedFemales);
        }

        private static void DisplayAges(int maxAge, int minAge, double averageAge)
        {
            Console.WriteLine($"Maximum Age: {maxAge}");
            Console.WriteLine($"Mininum Age: {minAge}");
            Console.WriteLine($"Average Age: {averageAge}\n");

        }

        private static void ShowList(List<Person> l)
        {
            foreach(Person p in l)
            {
                Console.WriteLine($"{p.surname}, {p.name} - {p.age}");
            }

            Console.WriteLine();
        }
    }
}
