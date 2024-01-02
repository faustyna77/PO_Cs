using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_lab4
{
    internal class Rectangle:Shape
    {
        public int x;
        public int y;
        public int height;
        public int weight;

        public Rectangle(int x,int y,int height,int weight)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.weight = weight;

        }
        public override void Draw()
        {
            Console.WriteLine("Rysowany jest prostokat o parametrach " + x + "," + y + " " + height + " " + weight);
        }

    }
}
