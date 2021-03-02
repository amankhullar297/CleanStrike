using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal abstract class CleanStrikeException :Exception
    {
        public CleanStrikeException()
        {

        }

        public CleanStrikeException(string message) : base(message)
        {

        }
    }
}
