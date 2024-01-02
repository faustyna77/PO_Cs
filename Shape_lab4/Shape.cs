using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_lab4
{
    class Shape
    {

        public int x;
        public int y;
        public int height;
        public int weight;
        public virtual void Draw()
        {
            Console.WriteLine("Rysowany jest kształt o parametrach " + x + "," + y + " " + height + " " + weight);
        }

    }
}
