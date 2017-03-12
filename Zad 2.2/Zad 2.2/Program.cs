using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag Gandalf = new Mag(Bohater.Rasa.Człowiek);
            Rzezimieszek Frodo = new Rzezimieszek(Bohater.Rasa.Hobbit);
            Wojownik Gimli = new Wojownik(Bohater.Rasa.Krasnolud);
            Gandalf.bijWroga();
            Gandalf.RzucCzar();
            Gandalf.sprawdzHp();

            Frodo.bijWroga();
            Frodo.sprawdzHp();

            Gimli.bijWroga();
            Gimli.RzucToporem();
            Gimli.sprawdzHp();

            Console.WriteLine("Uruk-Hai ginie.");
        }
    }
    public interface IBohater
    {
        void bijWroga();
        void sprawdzHp();

    }
}
