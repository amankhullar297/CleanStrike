using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class NoCoinException : CleanStrikeException
    {
        public NoCoinException()
        {

        }

        public NoCoinException(string message) : base(message)
        {

        }
    }
}
