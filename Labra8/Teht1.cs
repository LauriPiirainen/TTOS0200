using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Teht1
    {

        public static void Kirjoitus()
        {
            try
            {

                List<string> nameList = new List<string>();
                string filu = "Teht1filu.txt";
                System.IO.StreamWriter outputFile = new System.IO.StreamWriter(filu);

                string tempName;

                do
                {
                    Console.WriteLine("Anna nimi tai lopeta painamalla Enter");
                    tempName = Console.ReadLine();
                    if (tempName != "")
                    {
                        nameList.Add(tempName);
                    }

                }
                while (tempName != "");



                Console.WriteLine("Nimien määrä annettu: " + nameList.Count);
                for (int j = 0; j < nameList.Count; j++)
                {
                    if (nameList[j] != "")
                    {
                        Console.WriteLine("Kirjoitetaan tiedostoon: " + nameList[j]);
                        outputFile.WriteLine(nameList[j]);
                    }

                }
                outputFile.Close();


                System.IO.StreamReader reader = new System.IO.StreamReader(filu);
                Console.WriteLine("Tiedoston sisältö: ");
                string text = System.IO.File.ReadAllText(filu);
                Console.WriteLine(text);

                reader.Close();
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löytynyt");
            }

            catch (IOException e)
            {
                Console.WriteLine(e);
            }



        }

    }
}