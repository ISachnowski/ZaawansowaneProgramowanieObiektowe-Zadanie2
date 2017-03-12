using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2._2
{
    class Wojownik : Bohater
    {
        public Wojownik(Rasa rasa)
        {
            this.hp = 660;
            this.atak = 260;
            this.rasa = rasa;
        }
        public void RzucToporem()
        {
            Console.WriteLine("Rzuciłeś toporem. Zadane obrażenia: 250.");
        }
    }
}
