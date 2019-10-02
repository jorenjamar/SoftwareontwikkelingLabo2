using Coderingen;
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
            List<ICodering> gecodeerd = new List<ICodering>();
            gecodeerd.Add(new Codering(zin));

            String[] seperator = { "", " " };
            String[] coderingen = coderingInput.Split(seperator, (coderingInput.Count(x => x == ' ') + 1), StringSplitOptions.RemoveEmptyEntries) ;
            foreach (String codering in coderingen)
            {
                if (codering == "wissel")
                {
                    gecodeerd.Add(new Wissel(gecodeerd[gecodeerd.Count() - 1]));
                }
                else if (codering == "cijfer")
                {
                    gecodeerd.Add(new Cijfer(gecodeerd[gecodeerd.Count() - 1]));
                }
                else if (codering == "blok")
                {
                    gecodeerd.Add(new Blok(gecodeerd[gecodeerd.Count() - 1]));
                }
            }

            Console.WriteLine(gecodeerd[gecodeerd.Count() - 1].Tekst);
            Console.ReadLine();
        }
    }
}
