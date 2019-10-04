using System;
using System.Collections.Generic;
using System.Text;

namespace Bestandsbeheer 
{
    public class File : IFile
    {
        public string Name { get; }
        private string FileContent;
        public File(string fileName)
        {
            Name = fileName;
            FileContent = System.IO.File.ReadAllText("C:\\Users\\Joren\\Documents\\school\\eerste_jaar_IIW\\softwareontwikkeling2\\labo2\\Bestandsbeheer\\" + fileName);
        }
        public void RequestFile(string fileName)
        {
            Console.WriteLine(FileContent);
        }
    }
}
