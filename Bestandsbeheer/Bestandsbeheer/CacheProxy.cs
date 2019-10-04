using System;
using System.Collections.Generic;
using System.Text;

namespace Bestandsbeheer
{
    public class CacheProxy : IFile
    {
        List<File> files = new List<File>();

        public CacheProxy()
        {
            Console.WriteLine("making cache proxy");
        }
        public void RequestFile(string fileName)
        {
            if (!files.Exists(x => x.Name == fileName))
            {
                Console.WriteLine("making new file now");
                files.Add(new File(fileName));
            }
            files.Find(x => x.Name == fileName).RequestFile(fileName);
        }
    }
}
