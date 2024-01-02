using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task1One
{
    internal class Book
    {
        string tytul;
        DateTime rok_wydania;
        Person autor;
        public string Tytul
        {
            get;set;
        }
        public DateTime Rk_wydania
        {
            get;
            set;
        }

        public Person Autor
        {
            get;
            set;
        }


        public Book(string tytul,DateTime rok_wydania,Person autor)
        {
            Tytul = tytul;
            Rk_wydania = rok_wydania;
            Autor = autor;
        }


        public void ViewBook()
        {
            Console.WriteLine($"Tytuł to {Tytul} rok wydania to {Rk_wydania}  autor to {Autor.Imie}");
        }
    }
}
