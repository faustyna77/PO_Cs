using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task2_cs
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Nauczyciel nauczyciel = new Nauczyciel("Katarzyna", "Wich", 67899543, "WSPiA", "tak", "mgr");
            nauczyciel.ViewStudent();
        }


    }
}
