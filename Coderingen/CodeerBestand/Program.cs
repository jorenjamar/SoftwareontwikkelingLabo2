using Coderingen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeerBestand
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = "C:\\Users\\Joren\\Documents\\school\\eerste_jaar_IIW\\softwareontwikkeling2\\labo2\\Coderingen\\CodeerBestand\\";
            List<ICodering> coderingTypes = new List<ICodering>();

            Console.Write("Geef bestandsnaam voor de invoer: ");
            string bestandInvoer = Console.ReadLine();
            Console.Write("Geef bestandsnaam voor de uitvoer: ");
            string bestandUitvoer = Console.ReadLine();
            Console.Write("Geef coderingen: ");
            string coderingInput = Console.ReadLine();

            readFile(directory + bestandInvoer, coderingTypes);

            getDecorators(coderingTypes, coderingInput);

            writeFile(directory + bestandUitvoer, coderingTypes);

            Console.ReadLine();

        }

        static void readFile(string path, List<ICodering> coderingTypes)
        {
            try
            {
                string text = File.ReadAllText(path);
                coderingTypes.Add(new Codering(text));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("De input file bestaat niet");

            }
        }

        static void writeFile(string path, List<ICodering> coderingTypes)
        {
            File.WriteAllText(path, coderingTypes[coderingTypes.Count - 1].Tekst);
        }

        static void getDecorators(List<ICodering> coderingTypes, String coderingInput)
        {
            if (coderingTypes.Count > 0)
            {
                String[] seperator = { "", " " };
                String[] coderingen = coderingInput.Split(seperator, (coderingInput.Count(x => x == ' ') + 1), StringSplitOptions.RemoveEmptyEntries);
                foreach (String codering in coderingen)
                {
                    if (codering == "wissel")
                    {
                        coderingTypes.Add(new Wissel(coderingTypes[coderingTypes.Count() - 1]));
                    }
                    else if (codering == "cijfer")
                    {
                        coderingTypes.Add(new Cijfer(coderingTypes[coderingTypes.Count() - 1]));
                    }
                    else if (codering == "blok")
                    {
                        coderingTypes.Add(new Blok(coderingTypes[coderingTypes.Count() - 1]));
                    }
                }
                
            }
        }


    }
}
