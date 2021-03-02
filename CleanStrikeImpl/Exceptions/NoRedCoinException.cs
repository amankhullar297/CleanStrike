using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class NoRedCoinException : CleanStrikeException
    {
        internal NoRedCoinException()
        {

        }

        internal NoRedCoinException(string message) : base(message)
        {

        }
    }
}
