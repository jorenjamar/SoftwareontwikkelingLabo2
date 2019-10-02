using Coderingen;
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Codering codering = new Codering("Dit is een oefening op Desing Patterns");
            Blok gecodeerd = new Blok(codering);
            Console.WriteLine(gecodeerd.Code());
            string test = "abc";
        }
    }
}
