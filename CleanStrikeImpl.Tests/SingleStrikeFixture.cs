using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace CleanStrikeImpl.Tests
{
    public class SingleStrikeFixture
    {
        private readonly SingleStrike SingleStrike = new SingleStrike();

        [Fact]
        public void SingleStrike_WillAddOnePoint_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, SingleStrike, 1);

            player.Points.Should().Be(1);
            InterLocked.GetBlackCoins().Should().Be(8);
        }

        [Fact]
        public void SingleStrike_WillDecreaseBlackCoins_FromBoard()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, SingleStrike, 1);

            InterLocked.GetBlackCoins().Should().Be(8);
        }

        [Fact]
        public void NoCoinsExceptionIsThrown_IfNoCoinsAreLeft()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, SingleStrike, 9);

            Action action = () => CarromBoard.Striker.Strike(player, SingleStrike);
            action.Should().Throw<NoCoinException>();
        } 
    }
}
