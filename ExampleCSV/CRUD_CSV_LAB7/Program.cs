using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSV_LAB7
{
    internal class Program
    {

      public static void Main(string[] args)
        {
            CrudClass crud = new CrudClass();
            Console.Write("wybierz co chcesz zrobić ");
            Console.WriteLine("1 - jesli chcesz zapisać dane 2- jeśli chcesz odczytać dane z csv 3-jesli hcesz znaleźć dane  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    crud.WriteDataToCsv("sample.csv");
                    break;
                case 2:
                    crud.ReadAndDisplayDataFromCsv("sample.csv");
                    break;
                case 3:
                    Console.WriteLine("Podaj szukany element");
                    string searchElem = Console.ReadLine();
                    crud.SearchDataInCsv("sample.csv", searchElem);
                    break;
            }
        }



    }
}
