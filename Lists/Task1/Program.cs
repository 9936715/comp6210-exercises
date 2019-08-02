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
            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=10");

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

            string[] females = Females.Select(f => f.name).ToArray();

            Array.Sort(females);
            
            foreach (string f in females)
            {
                Console.WriteLine(f);
            }

        }
    }
}
