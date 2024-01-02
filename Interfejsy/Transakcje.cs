using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    public  class Transakcje:ITransakcje
    {

        public int ilosc;

        public int wartosc;

        public Transakcje(int ilosc)
        {
            this.ilosc = ilosc;
        }

        public  Transakcje(int ilosc,int wartosc)
        {
            this.ilosc = ilosc;
            this.wartosc = wartosc;
        }
      

        public int PoliczIlosc()
        {
            return ilosc;
        }

        public void WyswietlDane()
        {
            Console.WriteLine("Ilość to " +PoliczIlosc());
        }

    }
}
