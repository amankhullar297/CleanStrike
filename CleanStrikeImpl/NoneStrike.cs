using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    internal class NoneStrike : IStrike
    {
        public void Strike(Player player)
        {
            player.SuccessiveNonStrike++;

            if (player.SuccessiveNonStrike == 3)
            {
                player.Points--;
                player.SuccessiveNonStrike = 0;
            }
        }
    }
}
