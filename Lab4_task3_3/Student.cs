using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task3_3
{
    internal class Student:IStudent
    {
       public  string Kierunek { get; set; }
       public  string Uczelnia { get; set; }
       public int Rok { get; set; }
        public int Semestr { get; set; }

        public void WyswietlDane()
        {
            Console.WriteLine($"Dane : kierunek:{Kierunek},uczelnia{Uczelnia},rok {Rok},semestr{Semestr}");
        }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Student(string Kierunek,string Uczelnia,int Rok,int Semestr,string Imie,string Nazwisko)
        {
            this.Kierunek = Kierunek;
            this.Uczelnia = Uczelnia;
            this.Rok = Rok;
            this.Semestr = Semestr;
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
        }
        public void ReturnFullName()
        {
            Console.WriteLine($"Imie {Imie}Nazwisko {Nazwisko}");

        }
    }
}
