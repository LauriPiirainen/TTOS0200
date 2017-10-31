using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Teht2
    {
        public static void Lukeminen()
        {
            string path = @"C:\temp";
            int Lauri = 0;
            int Ossi = 0;
            int Pasi = 0;
            int Jaakko = 0;
            int Ville = 0;
            try
            {
                if (File.Exists(path + @"\nimet.txt"))
                {
                    List<string> listLine = new List<string>();

                    string[] lines = System.IO.File.ReadAllLines(path + @"\nimet.txt");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                        switch (line)
                        {
                            case "Lauri":
                                Lauri++;
                                break;
                            case "Ossi":
                                Ossi++;
                                break;
                            case "Pasi":
                                Pasi++;
                                break;
                            case "Jaakko":
                                Jaakko++;
                                break;
                            case "Ville":
                                Ville++;
                                break;
                        }
                    }

                    Console.WriteLine("Lauri: " + Lauri);
                    Console.WriteLine("Ossi: " + Ossi);
                    Console.WriteLine("Pasi: " + Pasi);
                    Console.WriteLine("Jaakko: " + Jaakko);
                    Console.WriteLine("Ville: " + Ville);

                }
                else
                {
                    Console.WriteLine("File.Exist gives false");
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedosto ei löydy");
            }


        }

    }
}