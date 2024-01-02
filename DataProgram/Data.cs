using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProgram
{
    internal class Data
    {
        private DateTime data;
      
        public void NowData()
        {
            data = DateTime.Now;
            Console.WriteLine("Dzisiejsza data "+ data);
        }

        public void AddDay()
        {
            Console.WriteLine(data.AddDays(1));
        }

        public void MinusDay()
        {
            Console.WriteLine(data.AddDays(-1));
        }
    }
}
