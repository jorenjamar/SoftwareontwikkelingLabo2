using System;
using System.Collections.Generic;
using System.Text;

namespace Coderingen
{
    public class Codering : ICodering
    {
        private string tekst;
        public string Tekst {
            get
            {
                return tekst;
            }
        }

        public string Code()
        {;
            return tekst;
        }

        public Codering(string tekst) {
            this.tekst = tekst;
        }
    }
}
