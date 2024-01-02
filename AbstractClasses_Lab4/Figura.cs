using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses_Lab4
{
    abstract class Figura
    {
        public  abstract  double Pole();
        public abstract double Obwod();
        public  virtual void Info()
        {

            Console.WriteLine("Pole figury wynosi" + Pole() + "obwód" + Obwod());
        }

    }
}
