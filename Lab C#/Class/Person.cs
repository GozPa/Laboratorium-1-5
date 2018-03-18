using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkBook
{
    class Person
    {
        private string name;
        private string surname;
        private Date birthdate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Date BirthDate
        {
            get { return birthdate; }
            set { birthdate = value ; }
        }

        public Person()
        {
            Console.WriteLine("Działa konstruktor klasy Person bez arg");
            name = "Jane";
            surname = "Doe";
            birthdate = new Date();
        }

        public Person(string n, string sn, Date bd)
        {
            Console.WriteLine("Działa konstruktor klasy Person z argumentami");
            name = n;
            surname = sn;
            birthdate = bd;
        }

        public Date getDate() { return birthdate; }
        public void setDate(Date bd) { birthdate = bd; }
    }
}
