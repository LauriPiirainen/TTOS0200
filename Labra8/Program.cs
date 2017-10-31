using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse tehtävä");
            Console.WriteLine("1. Tiedostoon kirjoittaminen");
            Console.WriteLine("2. Nimien lukeminen");
            Console.WriteLine("3. Numeroiden tallennus");

            try
            {
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Teht1.Kirjoitus();
                        break;

                    case 2:
                        Teht2.Lukeminen();
                        break;

                    case 3:
                        Teht3.Tallennus();
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Ei ole numero");
            }



        }
    }
}