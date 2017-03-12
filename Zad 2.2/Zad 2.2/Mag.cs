using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2._2
{
    class Mag : Bohater
    {
        private int mana;

        public Mag (Rasa rasa){
            this.rasa = rasa;
            this.hp = 320;
            this.atak = 80;
            this.mana = 580;
        }

        public void RzucCzar()
        {
            Console.WriteLine("Rzuciles czar. Zadane obrażenia: 300.");
        }
    }
}
