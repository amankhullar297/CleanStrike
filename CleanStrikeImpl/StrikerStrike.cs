using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class StrikerStrike : IStrike
    {
        public void Strike(Player player)
        {
            player.Fouls++;
            player.Points--;
            if (player.Fouls == 3)
            {
                player.Points--;
                player.Fouls = 0;
            }
        }
    }
}
