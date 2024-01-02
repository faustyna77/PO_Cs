using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task3_3
{
    internal class Osoba : IOsoba
    {

        public string Imie
        {
            get; set;
        }
        public string Nazwisko
        {
            get; set;
        }
        public Osoba(string Imie, string Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;


        }
        public void ReturnFullName()
        {
            Console.WriteLine($"Imie to {Imie} nazwisko to {Nazwisko}");
        }
        public void WypiszOsoby()
        {
           

            Console.WriteLine("podaj ilosc osób które chcesz  wprowadzić");
            int liczbaOsob = Convert.ToInt32(Console.ReadLine());
            Osoba[] persons = new Osoba[liczbaOsob];
            for (int j = 0; j < liczbaOsob; j++)
            {
                                Console.WriteLine("podaj imiona i nazwiska osób które chcesz wprowadzić ");
                string imie2 = Console.ReadLine();
                string nazwisko2 = Console.ReadLine();
                persons[j] =

                new Osoba(imie2, nazwisko2);


            
               
               

                
            }
            foreach (Osoba person in persons)
            {
                person.ReturnFullName();

            }







        }
    }




    }

