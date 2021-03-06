using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanStrikeImpl.Tests
{
    public class RedStrikeFixture
    {
        private readonly RedStrike RedStrike = new RedStrike();

        [Fact]
        public void RedStrike_WillAddMultiplePoint_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, RedStrike, 1);

            player.Points.Should().Be(3);
            CarromBoard.RedCoins.Should().Be(0);
        }

        [Fact]
        public void RedStrike_WillDecreaseRedCoins_FromBoard()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, RedStrike, 1);

            CarromBoard.RedCoins.Should().Be(0);
        }

        [Fact]
        public void NoRedCoinExceptionIsThrown_IfNoRedCoinsAreLeft()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, RedStrike, 1);

            Action action = () => CarromBoard.Striker.Strike(player, RedStrike);
            action.Should().Throw<NoRedCoinException>();
        }
    }
}
