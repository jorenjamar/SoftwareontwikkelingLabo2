using System;
using System.Collections.Generic;
using System.Text;

namespace Coderingen
{
    public class Wissel : ICodering
    {
        private ICodering ouder;
        private string tekst;
        public string Tekst {
            get
            {
                return tekst;
            }
            set { 
                Tekst = value;  
            } 
        }

        public string Code()
        {
            string code = "";
            char[] tekstArray = ouder.Tekst.ToCharArray();
            for (int i = 0; i < tekstArray.Length; i++)
            {
                if(i%2 == 0 && i+1 <= tekstArray.Length - 1)
                {
                    code += tekstArray[i + 1];
                }
                else if(i%2 != 0)
                {
                    code += tekstArray[i - 1];
                }
                else
                {
                    code += tekstArray[i];
                }
            }
            return code;
        }

        public Wissel(ICodering ouder)
        {
            this.ouder = ouder;
        }
    }
}
