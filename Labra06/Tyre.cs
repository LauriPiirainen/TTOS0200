using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra06
{
    class Tyre
    {
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public string Tyresize { get; set; }

        public Tyre()
        {

        }
        public Tyre(string valmistaja, string malli, string koko)
        {
            Manufacture = valmistaja;
            this.Model = malli;
            this.Tyresize = koko;
        }

        public override string ToString()
        {
            return "Valmistaja: " + Manufacture + " Malli:" + Model + " renkaan koko:" + Tyresize;
        }
    }

    class Auto
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        private const int maxRenkaat = 4;
        private int lkmRenkaat = 0;
        public string KokoNimi { get { return Nimi + " " + Malli; } }
        public List<Tyre> Renkaat { get; }

        public Auto()
        {
            Renkaat = new List<Tyre>();
        }

        public void AddTyre(Tyre rengas)
        {
            if (lkmRenkaat < maxRenkaat)
            {
                Renkaat.Add(rengas);
                lkmRenkaat++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Model, Nimi);
            }
            else
            {
                Console.WriteLine("No room for a new tyres..., sorry!");
            }
        }
        public override string ToString()
        {
            string s = "Kulkuneuvossa: " + Nimi + " malli :" + Malli + "\nrenkaat:";
            foreach (Tyre r in Renkaat)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
}