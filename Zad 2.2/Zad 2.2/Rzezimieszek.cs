using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2._2
{
    class Rzezimieszek : Bohater
    {
        private int energia;

        public Rzezimieszek(Rasa rasa)
        {
            this.atak = 160;
            this.hp = 490;
            this.rasa = rasa;
            this.energia = 100;
        }
       
    }
}
