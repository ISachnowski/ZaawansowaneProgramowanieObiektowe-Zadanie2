using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_2._3
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public void WypiszInfo() { }
    }
}
