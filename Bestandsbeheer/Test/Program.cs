using Bestandsbeheer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IFile cacheProxy = new CacheProxy();
            cacheProxy.RequestFile("eerste.txt");
            cacheProxy.RequestFile("eerste.txt");
            cacheProxy.RequestFile("tweede.txt");
            cacheProxy.RequestFile("tweede.txt");
            cacheProxy.RequestFile("eerste.txt");

            ProtectionProxy protectionProxy = new ProtectionProxy();
            protectionProxy.RequestFile("eerste.txt");
            protectionProxy.RequestFile("eerste.txt");
            Console.ReadLine();
        }
    }
}
