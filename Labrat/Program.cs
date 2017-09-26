using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string syote2 = "kissa";
            Console.WriteLine("kissa on luku {0}", Lab03.OnkoLuku(syote2));
            string syote3 = "asd";
            Console.WriteLine("asd on luku {0}", Lab03.OnkoLuku(syote3));
            string syote4 = "3aw";
            Console.WriteLine("3aw on luku {0}", Lab03.OnkoLuku(syote4));
            string syote5 = "12-2";
            Console.WriteLine("12-2 on luku {0}", Lab03.OnkoLuku(syote5));
            string syote6 = "3";
            Console.WriteLine("3 on luku {0}", Lab03.OnkoLuku(syote6));
            string syote7 = "3,3";
            Console.WriteLine("3,3 on luku {0}", Lab03.OnkoLuku(syote7));
            Console.WriteLine("----------------------------------------------------");
            string syote21 = "123";
            Console.WriteLine("{0} on luku {1}", syote21, Lab03.OnkoLuku(syote21));
            string syote22 = "-123";
            Console.WriteLine("{0} on luku {1}", syote22, Lab03.OnkoLuku(syote22));
            string syote23 = "+123";
            Console.WriteLine("{0} on luku {1}", syote23, Lab03.OnkoLuku(syote23));
            string syote24 = "8,123";
            Console.WriteLine("{0} on luku {1}", syote24, Lab03.OnkoLuku(syote24));
            string syote25 = "+9,123";
            Console.WriteLine("{0} on luku {1}", syote25, Lab03.OnkoLuku(syote25));
            string syote26 = "-9,123";
            Console.WriteLine("{0} on luku {1}", syote26, Lab03.OnkoLuku(syote26));
            string syote27 = ",";
            Console.WriteLine("{0} on luku {1}", syote27, Lab03.OnkoLuku(syote27));
            Console.WriteLine("----------------------------------------------------");
            string syote11 = "11.11.1234";
            Console.WriteLine("{0} on pvm {1}",syote11, Lab03.OnkoPvm(syote11));
            string syote12 = "11,11,11";
            Console.WriteLine("{0} on pvm {1}", syote11, Lab03.OnkoPvm(syote12));
            string syote13 = "11,11,1111";
            Console.WriteLine("{0} on pvm {1}", syote11, Lab03.OnkoPvm(syote13));
            string syote14 = "11.11.11";
            
            */
            do
            {
                Hissi uus = new Hissi();
                Console.WriteLine("Give a new floor number (1-5) >");
                int kerros = int.Parse(Console.ReadLine());


                if (kerros > 6 || kerros < 1)
                {
                    Console.WriteLine("Floor does not exist!");
                }

                if (kerros == 6)
                {
                    Console.WriteLine("You're a wizard harry! \nYou found a secret path to Hogwarts!");
                }

                else
                {
                    uus.NykyinenKerros = kerros;
                    Console.WriteLine("Elevator is now in floor : {0}", uus.NykyinenKerros);
                }
            } while (true);
            /*
            Vahvistin uus = new Vahvistin();
            do
            {
                Console.WriteLine("Give a new volume value (0-100) >");
                int aani = int.Parse(Console.ReadLine());
                uus.Aanenvoimakkuus = aani;
                if (aani > 100)
                {
                    uus.Saato = aani;
                    Console.WriteLine("-> Too much volume -  Amplifier volume will be set to maximum :{0}", uus.Aanenvoimakkuus);
                }
                if (aani < 0)
                {
                    uus.Saato = aani;
                    Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : {0}", uus.Aanenvoimakkuus);
                }
                else
                {
                    Console.WriteLine("-> Amplifier volume is set to : {0}", uus.Aanenvoimakkuus);
                }
            } while (true);*/
        }
    }
}