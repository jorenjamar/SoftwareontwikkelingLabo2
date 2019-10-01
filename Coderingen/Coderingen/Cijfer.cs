using System;
using System.Collections.Generic;
using System.Text;

namespace Coderingen
{
    public class Cijfer : ICodering
    {
        private ICodering ouder;
        private string tekst;
        public string Tekst
        {
            get
            {
                return tekst;
            }
            set
            {
                Tekst = value;
            }
        }

        public string Code()
        {
            byte[] codeArray = Encoding.ASCII.GetBytes(ouder.Tekst);
            string code = "";
            for(int i = 0; i < codeArray.Length; i++)
            {
                code += codeArray[i].ToString();
            }
            return code;
        }

        public Cijfer(ICodering ouder)
        {
            this.ouder = ouder;
        }
    }
}
