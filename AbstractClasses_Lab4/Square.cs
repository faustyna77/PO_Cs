using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses_Lab4
{
    internal class Square:Figura
    {
        public double a;
        public double b;

        public Square(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double  Pole()
        {
            return a * b;
        }

        public override double Obwod()
        {
            return 2 * a + 2 * b;
        }

       public override void Info()
        {
            Console.WriteLine("Pole kwadratu to" + Pole() + " " + Obwod());
        }


    }
}
