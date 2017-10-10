using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue Jyp = new Joukkue();
            Jyp.Name = "Jyp";
            Jyp.Kaupunki = " Jyväskylä";
            Jyp.pelaajat.Add(new Pelaaja("Jarkko Immonen", "Hyökkääjä", "Right"));
            Jyp.pelaajat.Add(new Pelaaja("Riku Tiainen", "Hyökkääjä", "Left"));
            Jyp.pelaajat.Add(new Pelaaja("Mikko Kuukka", "Puolustaja", "Left"));

            Joukkue Kalpa = new Joukkue();
            Kalpa.Name = "Kalpa";
            Kalpa.Kaupunki = " Kuopio";
            Kalpa.pelaajat.Add(new Pelaaja("Eetu Sopanen", "Puolustaja", "Right"));
            Kalpa.pelaajat.Add(new Pelaaja("Janne Tavi", "Hyökkääjä", "Left"));
            Kalpa.pelaajat.Add(new Pelaaja("Alexander Ruuttu", "Hyökkääjä", "Right"));

            Joukkue Karpat = new Joukkue();
            Karpat.Name = "Kärpät";
            Karpat.Kaupunki = " Oulu";
            Karpat.pelaajat.Add(new Pelaaja("Veini Vehviläinen", "Maalivahti", "Left"));
            Karpat.pelaajat.Add(new Pelaaja("Charles Bertrand", "Hyökkääjä", "Right"));
            Karpat.pelaajat.Add(new Pelaaja("Junttila Julius", "Hyökkääjä", "Right"));
            //Tätä voisi jatkaa niin pitkään, että olisi database kaikista

            Console.WriteLine("Minkä seuran pelaajatiedot haluat tulostaa(valitse numerolla) \n 1.Jyp \n 2.Kalpa \n 3.Kärpät \n");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Console.WriteLine(Jyp.ToString());
            }
            else if (valinta == 2)
            {
                Console.WriteLine(Kalpa.ToString());
            }
            else if (valinta == 3)
            {
                Console.WriteLine(Karpat.ToString());
            }
            else
            {
                Console.WriteLine("Kokeile uusiks");
            }
        }
    }
}