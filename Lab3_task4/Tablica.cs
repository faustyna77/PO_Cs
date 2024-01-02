using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task4
{
    class Tablica
    {
       int n;
        int sum = 0;
        int [] tablica;

        public void Tab10()
        {
          

            Console.WriteLine("podaj ilsc elementów w tablicy");
            n = Convert.ToInt32(Console.ReadLine());
            tablica = new int[n];
            for (int i = 0; i< n; i++)
            {
                tablica[i] = Convert.ToInt32(Console.ReadLine());

            }

        }

        public void AddTab()
        {
            for (int j = 0; j < n; j++)
            {

                sum += tablica[j];
            }
            Console.WriteLine("suma wynosi" + sum);
        }

        public void DivTab()
        {
            int sum2 = 1;
            for (int j = 0; j < n; j++)
            {
               
                sum2 *= tablica[j];
            }
            Console.WriteLine("wynik mnoenia elementów tablicy " + sum2);
        }
        public double Average()
        {
            return (double) sum / n;

        }





    }
}
