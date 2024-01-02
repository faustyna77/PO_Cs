using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_task2
{

    class Program
    {
        static void Main(string[] args)
        {
            Sumator sumator = new Sumator();
            sumator.FilTable();
            Console.WriteLine(sumator.ReturnSuma());
           Console.WriteLine( sumator.SumaPodziel2());
            sumator.IndexMetod(2,3);

        }
    }
}