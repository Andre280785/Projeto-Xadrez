using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro.Exception
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
