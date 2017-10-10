using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra06
{
    class Ajoneuvo
    {
        public string Valmistaja { get; set; }
        public string Model { get; set; }
        public int Size { get; set; }

        public Ajoneuvo()

        {

        }

        public Ajoneuvo(string merkki, string malli, int koko)
        {
            Valmistaja = merkki;
            Model = malli;
            Size = koko;
        }

        public override string ToString()

        {
            return "Merkki: " + Valmistaja + " Malli: " + Model + " Koko: " + Size;
        }

    }
}