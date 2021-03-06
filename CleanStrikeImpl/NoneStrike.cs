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
                player.Points -= 1;
                player.SuccessiveNonStrike = 0;
            }
        }
    }
}
