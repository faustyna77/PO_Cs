using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_lab4
{
     class Program
    {
        

        public static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(6,7,8,9),
                new Rectangle(2,3,4,5),
                new Triangle(5,6,7,8),
                new Circle(6,8,9,9)


            };


            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }

    }
}
