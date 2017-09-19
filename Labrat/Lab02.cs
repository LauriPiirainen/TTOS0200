//Labrat 02
//Lauri Piirainen

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab02
    {
        public class Kiuas
        {
            public bool paalla { get; set; }
            public int lampo { get; set; }
            public int kosteus { get; set; }
            public Kiuas(bool paalla, int Teho, int kosteus) : base()
            {
                this.paalla = paalla;
                this.lampo = Teho;
                this.kosteus = kosteus;
            }
            public Kiuas()
            {
            }
            public string warming()
            {
                string lampo = "Kiuas lampenee....\n";

                return lampo;
            }
            public string loyly()
            {
                string loylya = "Sihinaaaaa";

                return loylya;
            }
        }
        public class Kiuasohjaus
        {
            public static void ohjauspaneeli()
            {
                Kiuas omaHarvia = new Kiuas();
                Console.WriteLine("Haluatko käynnistää kiukaan (y/n)?");
                while (true)
                {
                    string vastaus = Console.ReadLine();
                    if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                    {
                        omaHarvia.paalla = true;
                        break;
                    }
                    else if (vastaus.Substring(0, 1) == "n" || vastaus.Substring(0, 1) == "N")
                    {
                        omaHarvia.paalla = false;
                        break;
                    }
                    Console.Write("Haluatko käynnistää kiukaan (y/n)?");
                }
                if (omaHarvia.paalla == true)
                {
                    Console.Write("Kuinka kuumaksi haluat saunan? ");
                    omaHarvia.lampo = int.Parse(Console.ReadLine());
                    Console.Write("Minka haluat saunan kosteudeksi? ");
                    omaHarvia.kosteus = int.Parse(Console.ReadLine());
                    Console.WriteLine(omaHarvia.warming());
                    Console.WriteLine("Sauna on nyt valmis! \nLampo on {0} celsiusta ja kosteus {1} prosenttia", omaHarvia.lampo, omaHarvia.kosteus);
                    while (omaHarvia.paalla == true)
                    {

                        Console.Write("Haluatko heittää löylyä (y/n)?");
                        string vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                        {
                            Console.WriteLine(omaHarvia.loyly());
                        }

                        Console.Write("Haluatko sammuttaa kiukaan? (y/n)?");
                        vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") omaHarvia.paalla = false;


                    }
                }


                Console.WriteLine("Kiuas on nyt sammutettu.");

            }
        }
        public class Pesukone
        {
            public bool paalla { get; set; }
            public int lampo { get; set; }
            public int pesumuoto { get; set; }
            public bool linkous { get; set; }

            public Pesukone(bool paalla, int lampo, int pesumuoto, bool linkous) : base()
            {
                this.paalla = paalla;
                this.lampo = lampo;
                this.pesumuoto = pesumuoto;
                this.linkous = linkous;
            }
            public Pesukone()
            {
            }
            public string running()
            {
                return "Pesukone on päällä: HURINAAA!";
            }
            public string lingging()
            {
                return "Pesukone linkoaa: rum,PUM,RUM,tum";
            }
        }
        public class Pesukoneohjaus
        {
            public static void ohjauspaneeli()
            {
                Pesukone Samsung = new Pesukone();
                Console.Write("Käynnistetäänkö pesukone (y/n)?");
                string vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") Samsung.paalla = true;
                else Samsung.paalla = false;
                if (Samsung.paalla == false) { Console.WriteLine("Näkemiin!"); Environment.Exit(1); }
                Console.Write("Millä lämpötilalla haluat pestä pyykkisi? ");
                Samsung.lampo = int.Parse(Console.ReadLine());
                Console.Write("Millä pesuohjelmalla haluat pestä pyykkisi? \n1-10 (Käsinpesu on 1 ja 10 on Erittäin likainen pyykki)? ");
                Samsung.pesumuoto = int.Parse(Console.ReadLine());
                Console.Write("Haluatko linkouksen (y/n)? ");
                vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") Samsung.linkous = true;
                string linko = "";
                if (Samsung.linkous == true) linko = "haluat linkouksen";
                else if (Samsung.linkous == false) linko = "et halua linkousta";
                Console.WriteLine("Seuraavat vaihtoehdot valittu: \nLämpötila {0} celsius astetta, \npesuohjelman voimakkuus {1} ja {2}.", Samsung.lampo, Samsung.pesumuoto, linko);
                Console.Write("Aloitetaanko ohjelma (y/n)? ");
                vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y")
                {
                    Console.WriteLine(Samsung.running());
                    if (Samsung.linkous == true)
                    {
                        Console.WriteLine("Aloitetaan linkous!");
                        Console.WriteLine(Samsung.lingging());
                    }
                    Console.WriteLine("Pesu-ohjelma on valmis!");
                }


                Console.WriteLine("Pesukone sammutetaan. Kiitos ja näkemiin!");


            }
        }
        public class Tv
        {
            public bool paalla { get; set; }
            public int kanava { get; set; }
            public int volume { get; set; }
            public Tv(bool paalla, int kanava, int volume) : base()
            {
                this.paalla = paalla;
                this.kanava = kanava;
                this.volume = volume;
            }
            public Tv()
            {
            }
            public string startting()
            {
                return "Käynnistyy: Psiumsth!";
            }
            public string change()
            {
                return "Psuimshhh!";
            }

        }
        public class Tvohjaus
        {
            public static void Controlpanel()
            {
                Tv lg = new Tv();
                Console.Write("Käynnistetäänkö televisio (y/n)? ");
                string vastaus = Console.ReadLine();
                if (vastaus.Substring(0, 1) == "y" || vastaus.Substring(0, 1) == "Y") lg.paalla = true;
                else lg.paalla = false;
                if (lg.paalla == true)
                {
                    Console.WriteLine(lg.startting());
                    do
                    {
                        Console.Write("Valitse kanava ");
                        lg.kanava = int.Parse(Console.ReadLine());
                        Console.Write("Anna äänen voimakkuus: ");
                        lg.volume = int.Parse(Console.ReadLine());
                        Console.WriteLine(lg.change());
                        Console.Write("Valitsit kanavan {0} ja äänen voimakkuutesi on {1} astetta. Haluatko vaihtaa jotain (y/n)?", lg.kanava, lg.volume);
                        vastaus = Console.ReadLine();
                        if (vastaus.Substring(0, 1) == "N" || vastaus.Substring(0, 1) == "n")
                        {
                            Console.Write("Haluatko sammuttaa television (y/n)? ");
                            vastaus = Console.ReadLine();
                            if (vastaus.Substring(0, 1) == "Y" || vastaus.Substring(0, 1) == "y") lg.paalla = false;
                        }
                    } while (lg.paalla != false);
                    Console.WriteLine("Telvisio sammuu, kiitos ja näkemiin!");
                    Console.WriteLine(lg.startting());
                }

            }
        }
        public class Auto
        {
            public string Merkki { get; set; }
            public int Nopeus { get; set; }
            public int Renkaat { get; set; }
            public Auto(string Merkki, int Nopeus, int Renkaat) : base()
            {
                this.Merkki = Merkki;
                this.Nopeus = Nopeus;
                this.Renkaat = Renkaat;
            }
            public Auto()
            {
            }
            public string info()
            {
                return Merkki + "\nAutosi max nopeus on: " + Nopeus + "km/h \n" + "Autossasi on " + Renkaat + " tuumaiset renkaat";
            }
        }
        public class Autotiedot
        {
            public static void autoinfo()
            {
                Auto theauto = new Auto();

                Console.Write("Minkä merkkinen auto sinulla on? ");
                theauto.Merkki = Console.ReadLine();
                Console.WriteLine("Kuinka monta km/h autosi kulkee? ");
                theauto.Nopeus = int.Parse(Console.ReadLine());
                Console.WriteLine("Montako tuumaiset renkaat autossasi on?");
                theauto.Renkaat = int.Parse(Console.ReadLine());



                Console.WriteLine("Tässä autosi tiedot: ");

                Console.WriteLine(theauto.info());


            }
        }
    }
}