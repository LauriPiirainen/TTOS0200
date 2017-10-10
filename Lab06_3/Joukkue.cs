using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_3
{
    class Joukkue
    {
        public string Name { get; set; }
        public string Kaupunki { get; set; }
        public List<Pelaaja> pelaajat;

        public Joukkue()
        {
            pelaajat = new List<Pelaaja>();

        }

        public override string ToString()
        {
            string retval = Name + Kaupunki + " sisältö:\n";
            foreach (Pelaaja item in pelaajat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;

        }
    }
}