using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_task1
{
    internal class Task1
    {
        private int value;
        public Task1(int value)
        {
            this.value = value;
        }

        public int Dodaj(int add)
        {
            return value + add;
        }

        public int Odejmij(int minus)
        {
            return value - minus;
        }

        public void ViewObject()
        {
            Console.WriteLine(value);
        }

    }
}
