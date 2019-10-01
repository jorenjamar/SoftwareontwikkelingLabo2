using Coderingen;
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Codering codering = new Codering();
            codering.Tekst = "HeLLos";
            Blok gecodeerd = new Blok(codering);
            Console.WriteLine(gecodeerd.Code());
        }
    }
}
