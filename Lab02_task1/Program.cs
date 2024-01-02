using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_task1
{
    class Program
    {
        static void Main()
        {
            Task1 task1 = new Task1(7);
            Console.WriteLine(task1.Dodaj(5));
          
            
            Console.WriteLine(task1.Odejmij(5));
            task1.ViewObject();
            Console.ReadLine();

        }
    }

    
}
