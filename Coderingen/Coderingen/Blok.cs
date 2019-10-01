using System;
using System.Collections.Generic;
using System.Text;

namespace Coderingen
{
    public class Blok : ICodering
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
            string code = ouder.Tekst.ToLower();
            //TODO enkel naar kleine letters omgezet
            return code;
        }

        public Blok(ICodering ouder)
        {
            this.ouder = ouder;
        }
    }
}
