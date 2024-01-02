using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task2_cs
{
    internal class Nauczyciel : Uczen
    {
        private string tytul;

        public Nauczyciel(string imie, string nazwisko, int pesel, string szkola, string sam_do_domu, string Tytul) : base(imie, nazwisko, pesel, szkola, sam_do_domu)
        {
            Tytul = tytul;  
        }

        Uczen[] uczniowie = new Uczen[]
        {
            new Uczen("Kalina","Lipinska",0069876543,"wspiA","tak"),
            new Uczen("Weronika","Laskowska",0067898644,"WSPiA","tak")
        };

        public override void SetSchool(string szkola)
        {
            this.szkola = szkola;
        }


        public override void SetCanGoHome(string sam_do_domu)
        {
            this.sam_do_domu = sam_do_domu;
        }


        public override void SetFirstName(string imie)
        {
            this.imie = imie;
        }
        public override void SetLastName(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
        public override void SetPesel(int pesel)
        {
            this.pesel = pesel;
        }
        public override int GetAge()
        {
            return pesel;
        }

        public override int GetGender()
        {
            return pesel;
        }
        public  void ViewStudent()
        {
            foreach(Uczen student in uczniowie)
            {
                Console.WriteLine($"Studenci nauczyciela {this.imie} {this.nazwisko}to {student.imie}  {student.nazwisko}");
            }
        }

    }
}
