using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Date my_date = new StalkBook.Date();

            Console.WriteLine("Dzień: " + my_date.getDay());
            Console.WriteLine("Miesiąc: " + my_date.getMonth());
            Console.WriteLine("Rok: " + my_date.getYear());
            Console.WriteLine(".............................");

            my_date.setDay('a');
            my_date.setMonth(5);
            my_date.setYear(3000);

            Console.WriteLine("Nowy Dzień: " + my_date.getDay());
            Console.WriteLine("Nowy Miesiąc: " + my_date.getMonth());
            Console.WriteLine("Nowy Rok: " + my_date.getYear());
            Console.WriteLine(".............................");

            Date new_date = new StalkBook.Date(7, 03, 2018);

            Console.WriteLine("Nowy Dzień: " + new_date.getDay());
            Console.WriteLine("Nowy Miesiąc: " + new_date.getMonth());
            Console.WriteLine("Nowy Rok: " + new_date.getYear());
            Console.WriteLine(".............................");

            Person person = new Person();

            
            Console.WriteLine("Imie: " + person.Name);
            Console.WriteLine("Nazwisko: " + person.Surname);
            Console.WriteLine("Data urodzin: " + person.BirthDate.getDay() + 
                "-" + person.BirthDate.getMonth() +
                "-" + person.BirthDate.getYear());
            Console.WriteLine(".............................");

            Person new_person = new Person("John", "Doe", new Date(29,03,1996));


            Console.WriteLine("Nowe Imie: " + new_person.Name);
            Console.WriteLine("Nowe Nazwisko: " + new_person.Surname);
            Console.WriteLine("Nowe_Data urodzin: " + new_person.BirthDate.getDay() +
                "-" + new_person.BirthDate.getMonth() +
                "-" + new_person.BirthDate.getYear());
            Console.WriteLine(".............................");

            person.Name = "Paulina";
            person.Surname = "Gozdek";
            person.BirthDate = new Date(11, 11, 1111);

            Console.WriteLine("Imie: " + person.Name);
            Console.WriteLine("Nazwisko: " + person.Surname);
            Console.WriteLine("Data urodzin: " + person.BirthDate.getDay() +
                "-" + person.BirthDate.getMonth() +
                "-" + person.BirthDate.getYear());
            Console.WriteLine(".............................");

            person.setDate(new StalkBook.Date(12, 12, 2021));
            Console.WriteLine("Data:" + person.BirthDate.getDay() + "-" + person.BirthDate.getMonth() + "-" + person.BirthDate.getYear());
            Console.ReadKey();
        }
    }
}
