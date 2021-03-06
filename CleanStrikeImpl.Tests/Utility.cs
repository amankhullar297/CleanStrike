using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl.Tests
{
    internal static class Utility
    {
        internal static void StrikeForNTimes<T>(Player player, T strikerType, int count) where T : IStrike
        {
            for (int i = 1; i <= count; i++)
            {
                CarromBoard.Striker.Strike(player, strikerType);
            }
        }

        internal static void ResetBoard()
        {
            InterLocked.SetBlackCoins(9);
            InterLocked.SetRedCoins(1);
        }
    }
}
