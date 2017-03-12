using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2._2
{
    abstract class Bohater : IBohater
    {
        protected int hp;
        protected int atak;
        protected Rasa rasa;
        public enum Rasa
        {
            Człowiek,
            Elf,
            Krasnolud,
            Hobbit
        }

        public void bijWroga()
        {
            Console.WriteLine("Uderzyłeś wroga. Zadane obrażenia: " + this.atak);
        }
        public void sprawdzHp()
        {
            Console.WriteLine("Twoje hp wynosi: " + this.hp);
        }
    }
}
