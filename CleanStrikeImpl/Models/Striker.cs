using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class Striker
    {
        internal void Strike(Player player, IStrike strikeType)
        {
            strikeType.Strike(player);
        }
    }
}