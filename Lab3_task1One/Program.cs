using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task1One
{
    class Program

    {

        public static void Main(String[] args)
        {

            Person[] persons = new Person[]
            {
                new Person("Anna","Kovalikowa",29),
            new Person("Bartek", "Lipiński", 19)
            };
            persons[0].Imie = "Wanda";


            Book[] books = new Book[]
            {
                new Book("Nad niemnem",new DateTime(1999,1,1),persons[0]),


            };
            foreach (Person item  in persons)
            {
                item.View();
                
            }
            foreach(Book book in books)

                {
               book.ViewBook();
            }
            Reader reader1 = new Reader("Anna", "Kowalska", 25);
            Book book1 = new Book("Nad Niemnem", new DateTime(2000, 1, 1), new Person("Eliza", "Orzeszkowa", 40));

            reader1.AddReadBook(book1);
            reader1.ViewReadBooks();

        }

    }
}
