using System;
using System.Collections.Generic;
using System.Text;

namespace Coderingen
{
    public class Cijfer : ICodering
    {
        private ICodering ouder;
        public string Tekst
        {
            get
            {
                return Code();
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
