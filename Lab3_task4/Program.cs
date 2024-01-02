using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task4
{
     class Program
    {

        static void Main()
        {
            Tablica t = new Tablica();
            t.Tab10();
            t.AddTab();
            t.DivTab();
            Console.WriteLine("Srednia arytmetyczna elementów tablicy to "+ t.Average());
        }
    }
}