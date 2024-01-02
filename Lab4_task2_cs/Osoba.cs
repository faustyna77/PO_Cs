using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task2_cs
{
   public class Osoba
    {

       public string imie;
      public   string nazwisko;
       public  int pesel;

      
        public Osoba(string imie,string nazwisko,int pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }
        public  virtual void SetFirstName(string imie)
        {
            this.imie = imie;
        }
        public virtual void SetLastName(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
        public virtual void SetPesel(int pesel)
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
