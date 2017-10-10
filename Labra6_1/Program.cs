using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Jääkaappi Boch = new Jääkaappi();
            Boch.Name = "Jääkaappi";

            Boch.sisältö.Add(new Ruoka("Maito", "Ovi"));
            Boch.sisältö.Add(new Ruoka("Mehu", "Ovi"));
            Boch.sisältö.Add(new Ruoka("Kana", "Keskellä"));
            Boch.sisältö.Add(new Ruoka("Juusto", "Ylähylly"));
            Boch.sisältö.Add(new Ruoka("Tomaatti", "Alahylly"));
            Boch.sisältö.Add(new Ruoka("Kurkku", "Alahylly"));

            Console.WriteLine(Boch.ToString());

        }
    }
}
