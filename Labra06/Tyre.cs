using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra06
{
    class Renkaat : Ajoneuvo
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int Koko { get; set; }

        public Renkaat()

        {

        }

        public Renkaat(string merkki, string malli, int koko)
        {
            Merkki = merkki;
            Malli = malli;
            Koko = koko;
        }

        public override string ToString()

        {
            return "Merkki: " + Merkki + " Malli: " + Malli + " Koko: " + Koko;
        }
    }
}