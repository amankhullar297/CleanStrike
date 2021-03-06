using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal static class InterLocked
    {
        internal static void DecrementBlackCoins()
        {
            lock (Locks.BlackCoinLock)
                CarromBoard.BlackCoins--;
        }

        internal static void DecrementRedCoins()
        {
            lock (Locks.RedCoinLock)
                CarromBoard.RedCoins--;
        }

        internal static void SetBlackCoins(int value)
        {
            lock (Locks.BlackCoinLock)
                CarromBoard.BlackCoins = value;
        }

        internal static void SetRedCoins(int value)
        {
            lock (Locks.RedCoinLock)
                CarromBoard.RedCoins = value;
        }

        internal static int GetBlackCoins()
        {
            var coins = 0;
            lock (Locks.BlackCoinLock)
                coins = CarromBoard.BlackCoins;

            return coins;
        }
    }
}
