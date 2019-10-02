using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Coderingen
{
    public class Blok : ICodering
    {
        private char[,] blokCode = {
                { 'a', 'z', 'e', 'r', 't', '1' },
                { '2', 'y', 'u', 'i', 'o', 'p' },
                { 'q', '3', 's', '4', '8', 'd' },
                { 'f', 'g', 'h', 'n', 'j', 'k' },
                { '9', '7', 'l', 'm', '6', 'w' },
                { '5', '0', 'x', 'c', 'v', 'b' },
            };
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
            string code = ouder.Tekst.ToLower();
            code = Regex.Replace(code, "[^a-z0-9]", "0");
            if (code.Length % 2 != 0)
            {
                code += "0";
            }
            string resultCode = "";
            for (int i = 0; i < code.Length; i += 2)
            {
                char letter1 = code[i], letter2 = code[i + 1];
                int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
                
                if(letter1 != letter2)
                {
                    
                    for (int y = 0; y < 6; y++)
                    {
                        for (int x = 0; x < 6; x++)
                        {
                            if (letter1 == blokCode[y, x])
                            {
                                y1 = y;
                                x1 = x;
                            }
                            if (letter2 == blokCode[y, x])
                            {
                                y2 = y;
                                x2 = x;
                            }
                        }
                    }
                    if (y1 == y2 || x1 == x2)
                    {
                        letter1 = blokCode[y2, x2];
                        letter2 = blokCode[y1, x1];
                    }
                    else
                    {
                        letter1 = blokCode[y1, x2];
                        letter2 = blokCode[y2, x1];
                    }
                    
                }
                resultCode += letter1.ToString() + letter2.ToString();
            }
            //TODO enkel naar kleine letters omgezet
            return resultCode;
        }

        public Blok(ICodering ouder)
        {
            this.ouder = ouder;
        }
    }
}
