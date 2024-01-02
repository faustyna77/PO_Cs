using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_ConsoleApp
{
    class Program
    {



        static void Main()
        {
            string choice;
            Calc calc = new Calc();
            do
            {
                Console.WriteLine("wybierz opcje 1-suma, 2 -różnica, 3- pierwiastek z liczby, 4-trygonometria jesli chcesz przestać napisz stop");
                Console.Write("     ");
                Console.WriteLine("-----------------");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":



                       Console.Write( calc.Addd());
                        break;
                    case "2":
                        calc.Div();
                        break;
                    case "3":
                        calc.Sqrt();
                        break;
                    case "4":
                        calc.Angle();
                        break;
                    default:
                        break;
                }

            }
            while (choice != "stop");
        }
    }
}
