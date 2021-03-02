using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal static class CarromBoard
    {
        internal static int BlackCoins { get; set; } = 9;
        internal static int RedCoins { get; set; } = 1;

        internal static Striker Striker = new Striker();
    }
}