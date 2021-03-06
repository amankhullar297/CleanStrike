using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class SingleStrike : IStrike
    {
        public void Strike(Player player)
        {
            if (InterLocked.GetBlackCoins() <= 0)
                throw new NoCoinException(Constants.Exceptions.Messages.NoCoins);

            player.Points++;
            InterLocked.DecrementBlackCoins();
        }
    }
}
