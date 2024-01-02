using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task3_3
{
    internal interface IStudent:IOsoba
    {
        string Kierunek { get; set; }
        string Uczelnia { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }
        void WyswietlDane();

    }
}
