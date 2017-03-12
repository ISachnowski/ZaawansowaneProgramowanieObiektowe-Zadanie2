using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            RollsRoyce RR = new RollsRoyce();
            ISamochod RRInterface = RR;
            RRInterface.wypiszMarke();
            RRInterface.wypiszSalon();
        }
    }

    interface ISamochod
    {
        void wypiszMarke();
        void wypiszSalon();
    }
}
