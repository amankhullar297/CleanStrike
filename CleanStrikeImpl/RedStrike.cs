using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class RedStrike : IStrike
    {
        public void Strike(Player player)
        {
            if (CarromBoard.RedCoins == 0)
                throw new NoRedCoinException(Constants.Exceptions.Messages.NoRedCoin);

            player.Points += 3;
            CarromBoard.RedCoins--;
        }
    }
}
