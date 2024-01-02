using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task1One
{
    class Person
    {


        public string imie, nazwisko;
     public    int wiek;
        public string  Imie 
            {
            get;
            set;
            }

        public string Nazwisko
        {
            get;
            set;
        }

        public int Wiek
        {
            get;
            set;
        }


        public Person(string imie,string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;

        }
        

        public void View()
        {
            Console.WriteLine($" imie to {Imie}, nazwisko to {Nazwisko} wiek to {Wiek}");
        }
    }
}
