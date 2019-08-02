using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Region { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public Birthday Birthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public CreditCard CreditCard { get; set; }
        public string Photo { get; set; }
     }

    class Birthday
    {
        public string DMY { get; set; }
        public string MDY { get; set; }
        public int Raw { get; set; }
    }

    class CreditCard
    {
        public string Expiration { get; set; }
        public string Number { get; set; }
        public int Pin { get; set; }
        public int Security { get; set; }
    }
}
