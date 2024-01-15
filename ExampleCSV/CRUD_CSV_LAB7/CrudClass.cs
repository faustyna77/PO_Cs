using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System;

namespace CRUD_CSV_LAB7
{
    internal class CrudClass
    {
        List<Persons> people;
        public  void WriteDataToCsv(string filePath)
        {
            Console.WriteLine("Podaj ile danych chcesz zapisać");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Podaj imie");
                string name = Console.ReadLine();
                string nazwisko = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                 people = new List<Persons>
            {
                new Persons { Imie = name, Nazwisko = nazwisko, Age = age }
              
            };
            }

            

           

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(people);
            }



            Console.WriteLine("Dane zapisane do pliku CSV.");
        }


        public void ReadAndDisplayDataFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Persons>().ToList();

                Console.WriteLine("\nDane odczytane z pliku CSV:");
                foreach (var person in records)
                {
                    Console.WriteLine($"Imię: {person.Imie}, Nazwisko: {person.Nazwisko}, Wiek: {person.Age}");
                }
            }
        }
        public void SearchDataInCsv(string filePath, string searchTerm)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Persons>().Where(p => p.Imie.Contains(searchTerm) || p.Nazwisko.Contains(searchTerm)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                foreach (var person in records)
                {
                    Console.WriteLine($"Imię: {person.Imie}, Nazwisko: {person.Nazwisko}, Wiek: {person.Age}");
                }
            }
        }

    }
}
