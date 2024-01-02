using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_task2
{
    internal class Sumator
    {

        public int[] liczby;
        int n;
        public void FilTable()
        {
            Console.WriteLine("podaj liczby (20 liczb)");
         
            Console.WriteLine("Podaj liczbe elementów w tablicy ");
            n = Convert.ToInt32(Console.ReadLine());
            liczby = new int[n];

            for(int i=0;i<n;i++)
            {
                liczby[i] = Convert.ToInt32(Console.ReadLine());


            }
        }
        public int ReturnSuma()
        {
            int sum;
            sum = 0;
            for(int j=0;j<n;j++)
            {
                sum += liczby[j];
            }
            return sum;
        }
        public int SumaPodziel2()
        {
            int sum2 = 0;
            for (int j = 0; j < n; j++)
            {
               
                if (liczby[j]%2==0)
                {
                    sum2 += liczby[j];
                }
            }
            return sum2; 

        }
        public void IndexMetod(int lowindex,int highindex)
        {
            
                for (int i = 0; i < n; i++)
                {
                if (n > lowindex && n < highindex)
                {


                    Console.WriteLine(liczby[i]);
                }
                }
            
        }
    }
}
