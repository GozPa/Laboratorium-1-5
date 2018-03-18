using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StalkBook
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date() {
            Console.WriteLine("Działa konstruktor klasy Date bez arg");
            day = 1;
            month = 1;
            year = 1900;
        }

        public Date(int d,int m, int y)
        {
            Console.WriteLine("Działa konstruktor klasy Date z argumentami");
            day = d;
            if (m <= 0 || m > 12)
            {
                Console.WriteLine("Podano złą wartość.");
                Console.WriteLine("Wprowadzona wartość zostabnie zastąpiona domyślną.");
                month = 1;
            }
            else { month = m; }
            if (y <= 0 || y > 2018)
            {
                Console.WriteLine("Podano złą wartość.");
                Console.WriteLine("Wprowadzona wartość zostabnie zastąpiona domyślną.");
                year = 1900;
            }
            else { year = y; }
        }


        public int getDay() { return day; }
        public int getMonth() { return month; }
        public int getYear() { return year; }

        public void setDay(int d) {
            if (d <= 0 || d > 31)
            {
                Console.WriteLine("Podano złą wartość.");
                Console.WriteLine("Wprowadzona wartość zostabnie zastąpiona domyślną.");
                day = 1;
            }
            else { day = d; }
        }
        
        public void setMonth(int m) {
            if (m <= 0 || m > 12)
            {
                Console.WriteLine("Podano złą wartość.");
                Console.WriteLine("Wprowadzona wartość zostabnie zastąpiona domyślną.");
                month = 1;
            }
            else { month = m; }
        }
       
        public void setYear(int y) {
            if (y <= 0 || y > 2018)
            {
                Console.WriteLine("Podano złą wartość.");
                Console.WriteLine("Wprowadzona wartość zostabnie zastąpiona domyślną.");
                year = 1900;
            }
            else { year = y;}
        }
         
    }
}
