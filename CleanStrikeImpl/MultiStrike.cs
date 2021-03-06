using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class MultiStrike : IStrike
    {
        public void Strike(Player player)
        {
            if (InterLocked.GetBlackCoins() <= 1)
                throw new NoCoinException(Constants.Exceptions.Messages.NoCoins);

            player.Points += 2;
        }
    }
}