using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task5
{
     class Task5
    {


       


        public void AddToLiczby()
        {
            //int[] liczby = new int[20];
            for (int i=0;i<=20;i++)
            {
               // liczby[i] = i;
                if (i==2|| i == 6 || i==9|| i==15 || i==19)
                {
                    continue;
                    
                }
                Console.WriteLine(i);




            }
        }
        
    }
}
