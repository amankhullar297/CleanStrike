using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal static class Locks
    {
        internal static readonly object BlackCoinLock = new object();
        internal static readonly object RedCoinLock = new object();
    }
}
