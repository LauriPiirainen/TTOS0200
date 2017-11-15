using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotalli
{
    public static class AutoTalli
    {
        public static List<Auto> HaeAutot()
        {
            List<Auto> autot = new List<Auto>();
            //GUIn testaamista varten keksitään muutama auto
            Auto a = new Auto();
            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.VM = 2007;
            a.KM = 200000;
            a.Hinta = 9000F;
            a.URL = "VolvoV70.png";
            autot.Add(a);
            //Toinenkin auto
            Auto b = new Auto()
            { Merkki = "Audi", Malli = "A4", VM = 2010, KM = 10000, Hinta = 10000, URL = "AudiA4.png"};
            autot.Add(b);
            //Kolmas
            Auto c = new Auto()
            { Merkki = "Saab", Malli = "95", VM = 1996, KM = 1000000, Hinta = 100, URL = ""};
            autot.Add(c);
            //
            Auto d = new Auto()
            { Merkki = "Wolksvagen", Malli = "Golf", VM = 2001, KM = 281000, Hinta = 1000, URL = "Golf.jpg" };
            autot.Add(d);
            //palautus
            return autot;
        }
    }

    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int VM { get; set; }
        public int KM { get; set; }
        public float Hinta { get; set; }
        public string URL { get; set; }
    }
}
