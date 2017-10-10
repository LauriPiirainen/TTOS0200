using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra06
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo Jaguar = new Ajoneuvo("Jaguar", "XE", 4);
            Ajoneuvo KTM = new Ajoneuvo("KTM", "Duke 200", 2);


            Renkaat Pirelli = new Renkaat("Pirelli", "P-Zero", 20);
            Renkaat Nokia = new Renkaat("Nokia", "Hakkapeliitta", 17);



            List<Renkaat> Tires = new List<Renkaat>();

            for (int i = 0; i < Jaguar.Size; i++)
            {
                Tires.Add(Pirelli);

            }
            for (int i = 0; i < KTM.Size; i++)
            {
                Tires.Add(Nokia);
            }
            foreach (Renkaat item in Tires)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}