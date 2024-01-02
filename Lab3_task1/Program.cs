using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task1
{



    class Program
    {
        static void Main()
        {


         

            Person[] people = new Person[] {
    new Person("Autor 1","Autor 1"),
    new Person("Autor 2","Nowak"),
    new Person("Autor 3","Kowalski"),
    new Person("Autor 4","Nowakowska")
};

            Console.WriteLine("======= Osoby ==========");
            foreach (Person item in people)
            {
                item.View();
            }
        }
    }
}
