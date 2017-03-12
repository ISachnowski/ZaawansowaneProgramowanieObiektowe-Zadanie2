using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RollsRoyce : ISamochod
    {
        private string marka;
        private string salon;


        public void wypiszMarke()
        {
            Console.WriteLine("Ta marka to Rolls Royce.");
        }

        public void wypiszSalon()
        {
            Console.WriteLine("Ten z samochod jest z salonu Rolls Royce'a");
        }
    }
}
