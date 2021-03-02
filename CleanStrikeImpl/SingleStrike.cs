using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class SingleStrike : IStrike
    {
        public void Strike(Player player)
        {
            int coin = 1;
            if (CarromBoard.BlackCoins - coin <= 0)
                throw new NoCoinException(Constants.Exceptions.Messages.NoCoins);

            player.Points += 1;
            CarromBoard.BlackCoins -= coin;
        }
    }
}
