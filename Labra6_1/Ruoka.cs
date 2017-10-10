using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6_1
{
    class Ruoka
    {
        public string Nimi { get; set; }
        public string Paikka { get; set; }

        public Ruoka()
        {
        }
        public Ruoka(string nimi, string paikka)
        {
            Nimi = nimi;
            Paikka = paikka;
        }
        public override string ToString()
        {
            return Nimi + " paikassa " + Paikka;
        }
    }
}