using System;
using System.Collections.Generic;
using System.Text;

namespace Coderingen
{
    public interface ICodering
    {
        string Tekst { get; }

        string Code();
    }
}
