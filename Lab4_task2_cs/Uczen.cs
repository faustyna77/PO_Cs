using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task2_cs
{
    internal class Uczen:Osoba
    {

        public string szkola;
        public string sam_do_domu;
        
        public Uczen(string imie,string nazwisko,int pesel,string szkola,string sam_do_domu):base( imie, nazwisko, pesel)
        {
            this.szkola = szkola;
            this.sam_do_domu = sam_do_domu ;
        }

        public virtual void SetSchool(string szkola)
        {
            this.szkola=szkola;
        }


        public virtual void SetCanGoHome(string sam_do_domu)
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
        public virtual int GetAge()
        {
            return pesel;
        }

        public virtual int GetGender()
        {
            return pesel;
        }

    }
}
