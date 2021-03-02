using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class DefunctStrike : IStrike
    {
        public void Strike(Player player)
        {
            if (CarromBoard.BlackCoins == 0)
                throw new NoCoinException(Constants.Exceptions.Messages.NoCoins);

            CarromBoard.BlackCoins--;
            player.Fouls++;
            player.Points -= 2;

            if (player.Fouls == 3)
            {
                player.Points--;
                player.Fouls = 0;
            }
        }
    }
}
