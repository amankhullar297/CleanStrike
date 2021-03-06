namespace CleanStrikeImpl
{
    internal class DefunctStrike : IStrike
    {
        public void Strike(Player player)
        {
            if (InterLocked.GetBlackCoins() == 0)
                throw new NoCoinException(Constants.Exceptions.Messages.NoCoins);

            InterLocked.DecrementBlackCoins();
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