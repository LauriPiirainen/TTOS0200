using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_3
{
    class Pelaaja
    {
        public string Nimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }

        public Pelaaja()
        {
        }
        public Pelaaja(string nimi, string pelipaikka, string kätisyys)
        {
            Nimi = nimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
        }
        public override string ToString()
        {
            return Nimi + " pelipaikka: " + Pelipaikka + " kätisyys: " + Kätisyys;
        }

    }
}