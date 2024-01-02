using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task1One
{
     internal class Reader : Person
    {
        // Lista książek przeczytanych przez czytelnika
        private List<Book> readBooks;

        // Konstruktor
        public Reader(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
            // Inicjalizacja listy książek
            readBooks = new List<Book>();
        }

        // Metoda dodająca książkę do listy przeczytanych książek
        public void AddReadBook(Book book)
        {
            readBooks.Add(book);
        }

        // Metoda wyświetlająca tytuły książek przeczytanych przez czytelnika
        public void ViewReadBooks()
        {
            Console.WriteLine($"Książki przeczytane przez czytelnika {Imie} {Nazwisko}:");

            if (readBooks.Count == 0)
            {
                Console.WriteLine("Brak przeczytanych książek.");
            }
            else
            {
                foreach (Book book in readBooks)
                {
                    Console.WriteLine($"Tytuł: {book.Tytul}, Rok wydania: {book.Rk_wydania}, Autor: {book.Autor.Imie} {book.Autor.Nazwisko}");
                }
            }
        }
    }
}
