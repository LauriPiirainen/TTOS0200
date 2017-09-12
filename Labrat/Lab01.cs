using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
//Labrat nro. 1. 
// Lauri Piirainen
{
    class Lab01
    {
        public static void Tehtava1()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua 
            int luku;
            Console.WriteLine("Anna luku>> ");
            luku = int.Parse(Console.ReadLine());
            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            else if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            else if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            else
            {
                Console.WriteLine("Joku muu luku");
            }
            Console.ReadLine();
        
        }
        public static void Tehtava2()
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero:
            int luku;
            Console.WriteLine("Anna Pistemaara>> ");
            luku = int.Parse(Console.ReadLine());
            if (luku >= 0 && luku <= 1)
            {
                Console.WriteLine("Koulunumero on: 0");
            }
            else if (luku >= 2 && luku <= 3)
            {
                Console.WriteLine("Koulunumero on: 1");
            }
            else if (luku >= 4 && luku <= 5)
            {
                Console.WriteLine("Koulunumero on: 2");
            }
            else if (luku >= 6 && luku <= 7)
            {
                Console.WriteLine("Koulunumero on: 3");
            }
            else if (luku >= 8 && luku <= 9)
            {
                Console.WriteLine("Koulunumero on: 4");
            }
            else if (luku >= 10 && luku <= 12)
            {
                Console.WriteLine("Koulunumero on: 5");
            }
            else
            {
                Console.WriteLine("Vaara lukuarvo.....");
            }
            Console.ReadLine();
        }
        public static void Tehtava3()
        {
            //Tee ohjelma, joka kysyy käyttäjältä kolme lukua
            // ja tulostaa niiden summan ja keskiarvon.
            int luku, luku2, luku3, yhteen;
            double keskia;
            Console.WriteLine("Anna ensimmainen luku ja paina entteria>> ");
            luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku ja paina entteria>> ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku ja paina entteria>> ");
            luku3 = int.Parse(Console.ReadLine());
            // Laskee summan
            yhteen = luku + luku2 + luku3;
            // Laskee keskiarvon
            float dividend = 3;
            keskia = (luku + luku2 + luku3) / dividend;
            Console.WriteLine("Numeroiden summa on {0}", yhteen);
            Console.WriteLine("Numeroiden keskiarvo on " + keskia);
            Console.ReadLine();
        }
        public static void Tehtava4()
        {
            //Mihin ikäluokkaan henkilö kuuluu
            int ika;
            Console.WriteLine("Anna ikasi ja paina entteria>> ");
            ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("Alaikainen");
            }
            else if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
            Console.ReadLine();
        }
        public static void Tehtava5()
        {
            //Ilmoittaa sekunnit tunteina 
            int luku, tunnit, minuutit, sekunnit;
            Console.WriteLine("Anna sekuntit >> ");
            luku = int.Parse(Console.ReadLine());
            tunnit = luku / 3600;
            minuutit = (luku % 3600) / 60;
            sekunnit = ((luku % 3600) % 60);
            Console.WriteLine("Antamasi sekuntiaika voidaan ilmaista muodossa: " + tunnit + " tuntia " + minuutit + " minuuttia ja " + sekunnit + " sekuntia");
            Console.ReadLine();
        }
        public static void Tehtava6()
        {
            //Laskee kulutuksen autoillessa. 
            double luku, kulutus, hinta;
            Console.WriteLine("Anna matka >> ");
            luku = double.Parse(Console.ReadLine());
            kulutus = (7.02 / 100) * luku;
            hinta = 1.595 * kulutus;
            Console.WriteLine("Bensaa kuluu {0:.##} litraa, kustannus {1:.##} euroa", kulutus, hinta);
            Console.ReadLine();
        }
        public static void Tehtava7()
        {
            //onko vuosi karkausvuosi?
            double luku;
            Console.WriteLine("Anna vuosi >> ");
            luku = double.Parse(Console.ReadLine());
            if ((luku % 4 == 0 && luku % 100 != 0) || (luku % 400 == 0))
            {
                Console.WriteLine("{0} on karkausvuosi", luku);
            }
            else
            {
                Console.WriteLine("{0} ei ole karkausvuosi", luku);
            }
            Console.ReadLine();
        }
        public static void Tehtava8()
        {
            //ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
            int[] luku = new int[3];
            Console.Write("Anna ensimmäinen luku: ");
            luku[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            luku[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            luku[2] = int.Parse(Console.ReadLine());
            if (luku[1] > luku[0])
            {
                luku[0] = luku[1];
                //vaihtaa suurimman luvun paikkaan 0
                if (luku[2] > luku[0])
                {
                    luku[0] = luku[2];
                }
            }
            if (luku[2] > luku[0])
            {
                luku[0] = luku[2];
            }
            Console.WriteLine("Suurin luku:" + luku[0]);
            Console.ReadLine();
        }
        public static void Tehtava9()
        {
            //ohjelma, joka kysyy käyttajalta lukuja, kunnes han syottaa luvun 0.
            //Ohjelman tulee tulostaa syotettyjen lukujen summa.
            int i, luku, kokonais;
            kokonais = 0;
            i = 1;
            while (i != 0)
            {
                Console.WriteLine("Anna luku, kun haluat lopettaa lukujen antamisen niin anna 0 >> ");
                luku = int.Parse(Console.ReadLine());
                kokonais += luku;
                if (luku == 0)
                {
                    Console.WriteLine("Summa on " + kokonais);
                    i = 0;
                }
            }
            Console.ReadLine();
        }
        public static void Tehtava10()
        {
            //ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = 
            //[1,2,33,44,55,68,77,96,100]. Käy sovelluksessa taulukko läpi ja tulosta 
            //ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int j = 0;
            for (int i = 0; i < 9;)
            {
                //Katsoo jakojäännöksestä onko luku parillinen
                j = luvut[i] % 2;
                if (j == 0)
                {
                    Console.WriteLine("HEPpi!");
                }
                i++;
            }
            Console.ReadLine();
        }
        public static void Tehtava11()
        {
            //Ohjelma joka tulostaa tähtirivejä käyttäjän antaman määrän mukaan
            Console.WriteLine("Anna luku >");
            int b = int.Parse(Console.ReadLine());
            b = b + 1;
            //For silmukan sisällä silmukka
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
        public static void Tehtava12()
        {
            //ohjelma, joka kysyy kaayttajaltä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon.
            //Ohjelman tulee tulostaa annetut luvut kaanteisessä jarjestyksessa.
            int[] luvut = new int[5];
            //Kysyy luvut
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna luku:");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            //muodostaa taulukon
            Array.Reverse(luvut);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(luvut[i] + ", ");
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
        public static void Tehtava13()
        {
            //ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden
            //summan siten, etta summasta on vähennetty pois pienin ja suurin tyylipiste.
            int[] luvut = new int[5];
            int kokonaisl = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna pisteet:");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(luvut);
            kokonaisl = luvut[1] + luvut[2] + luvut[3];
            Console.WriteLine("Pisteet " + kokonaisl);
            Console.ReadLine();
        }
        public static void Tehtava14()
        {
            //ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta
            int nollat = 0;
            int ykköset = 0;
            int kakkoset = 0;
            int kolmoset = 0;
            int neloset = 0;
            int vitoset = 0;
            int a;
            Console.WriteLine("Anna arvosanojen määrä >");
            a = int.Parse(Console.ReadLine());
            int[] luvut = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Anna arvosana 1-5:");
                luvut[i] = int.Parse(Console.ReadLine());
                if (luvut[i] == 0)
                {
                    nollat = nollat + 1;
                }
                if (luvut[i] == 1)
                {
                    ykköset = ykköset + 1;
                }
                if (luvut[i] == 2)
                {
                    kakkoset = kakkoset + 1;
                }
                if (luvut[i] == 3)
                {
                    kolmoset = kolmoset + 1;
                }
                if (luvut[i] == 4)
                {
                    neloset = neloset + 1;
                }
                if (luvut[i] == 5)
                {
                    vitoset = vitoset + 1;
                }
            }
            Console.WriteLine("Arvosanat:");
            Console.Write("0:");
            for (int d = 0; d < nollat; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 1:");
            for (int d = 0; d < ykköset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 2:");
            for (int d = 0; d < kakkoset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 3:");
            for (int d = 0; d < kolmoset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 4:");
            for (int d = 0; d < neloset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 5:");
            for (int d = 0; d < vitoset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            Console.ReadLine();
        }
        public static void Tehtava15()
        {
            //Kuusi (puu) tulostus, jossa kayttajalta kysytaan puun kokoa ja tulostetaan se * merkillä.
            int taso;
            Console.Write("Kuinka korkean puun haluat: ");
            taso = int.Parse(Console.ReadLine());
            for (int i = 0; i < taso - 2; i++)
            {
                for (int j = 0; j < taso - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            //Puun juuri
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < taso - 1; x++)
                {
                    Console.Write(" ");

                }
                Console.WriteLine("*");
            Console.ReadLine();
            }
}
        public static void Tehtava16()
        {
            //Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100
            // Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. 
            //Ohjelman antaa vihjeen arvauksen jälkeen onko arvottu luku pienempi vai suurempi.
            Random rnd = new Random();
            int numero = rnd.Next(1, 100);
            int arvaus=0, maara = 0;
            Console.Write("Arvaa randomin valitsema numero väliltä 1-100: ");
            
            while (numero != arvaus)
            {                
                arvaus = int.Parse(Console.ReadLine());
                maara++;
                if (arvaus > numero)Console.Write("Se on pienempi: ");
                if (arvaus < numero)Console.Write("Se on suurempi: ");
                
            } 
            Console.WriteLine("Onneksi olkoon arvasit oikein! Siihen sinulla meni {0} yritystä...", maara);
            Console.ReadLine();
            }
    }

}