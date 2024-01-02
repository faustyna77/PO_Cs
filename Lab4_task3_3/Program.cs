using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task3_3
{
     class Program
    {


        static void Main()
        {

            Osoba osoba = new Osoba("Jadwiga","Borowiec");
            osoba.WypiszOsoby();

            Student student = new Student("mechatronika", "Uniwersytet", 2022, 5, "John", "Doe");

            student.ReturnFullName();
            

           
        }


    }
}
