using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_ConsoleApp
{
    internal class Calc
    {



        public double Addd()

        {
            int sum = 0;
            Console.WriteLine("Podaj ile liczb chcesz dodać");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<x;i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            return (double) sum;
            
        }


        public double Div()
        {
            int div = 0;
            Console.WriteLine("Podaj ile liczb chcesz odjac");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= x; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                div -= number;
            }
            return (double)div;

        }

        public void Sqrt()
        {
            Console.WriteLine("podaj liczbe, której pierwiastek chcesz obliczyc");
            double sqrtNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pierwiastek z liczby " + sqrtNumber + "wynosi" + Math.Sqrt(sqrtNumber));

        }
        public void Angle()
        {
            Console.WriteLine("Podaj kąt w stopniach ");
            int angle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wybierz funkcje której wartość chcesz obliczyć" +
                "1- jesli sinus, 2- cosinus,3-tangens,4-ctg");
            string yourChoice = Console.ReadLine();
            switch(yourChoice)
            {
                case "1":
                    Console.WriteLine("Sinus"+angle+" wynosi "+Math.Sin((angle*3.14)/180));
                    break;
                case "2": Console.WriteLine("Cosinus" + angle + " wynosi " + Math.Cos((angle * 3.14) / 180));
                    break;
                case "3":
                    Console.WriteLine("Tangens" + angle + " wynosi " + Math.Tan((angle * 3.14) / 180));
                    break;
                case "4":
                    Console.WriteLine("CTangens" + angle + " wynosi " + 1/(Math.Tan((angle * 3.14) / 180)));
                    break;
            }
        }



        



    }
}
