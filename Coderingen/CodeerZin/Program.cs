﻿using Coderingen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeerZin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef zin: ");
            string zin = Console.ReadLine();
            Console.Write("Geef coderingen: ");
            string coderingInput = Console.ReadLine();

            List<ICodering> coderingTypes = new List<ICodering>();
            coderingTypes.Add(new Codering(zin));

            getDecorators(coderingTypes, coderingInput);

            Console.WriteLine(coderingTypes[coderingTypes.Count() - 1].Tekst);
            Console.ReadLine();
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
