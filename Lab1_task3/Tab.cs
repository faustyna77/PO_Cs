using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_task3
{
    class Tab
    {
        int[] tab = new int[10];

        public void EnterData()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void ShowData()
        {
            Console.WriteLine("All elements:");
            for (int j = 0; j < tab.Length; j++)
            {
                Console.WriteLine(tab[j]);
            }
        }

        public void ShowPar()
        {
            Console.WriteLine("Even elements:");
            for (int j = 0; j < 10; j++)
            {
                if (tab[j] % 2 == 0)
                {
                    Console.WriteLine(tab[j]);
                }
            }
        }

        public void ShowUnPar()
        {
            Console.WriteLine("Odd elements:");
            for (int j = 0; j < 10; j++)
            {
                if (tab[j] % 2 != 0)
                {
                    Console.WriteLine(tab[j]);
                }
            }
        }
    }
}