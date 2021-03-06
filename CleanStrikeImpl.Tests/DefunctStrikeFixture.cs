using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace CleanStrikeImpl.Tests
{
    public class DefunctStrikeFixture
    {
        private readonly DefunctStrike DefunctStrike = new DefunctStrike();

        [Fact]
        public void DefunctStrike_WillDecreasePoint_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, DefunctStrike, 1);

            player.Points.Should().Be(-2);
        }

        [Fact]
        public void DefunctStrike_WillIncreaseFoul_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, DefunctStrike, 1);

            player.Fouls.Should().Be(1);
        }

        [Fact]
        public void DefunctStrike_WillDecreaseBlackCoins_FromBoard()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, DefunctStrike, 1);

            InterLocked.GetBlackCoins().Should().Be(8);
        }

        [Fact]
        public void DefunctStrike_WillDecreaseAdditionalPoint_For3Fouls_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, DefunctStrike, 3);

            player.Points.Should().Be(-7);
        }

        [Fact]
        public void NoCoinExceptionIsThrown_IfNoRedCoinsAreLeft()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, DefunctStrike, 9);

            Action action = () => CarromBoard.Striker.Strike(player, DefunctStrike);
            action.Should().Throw<NoCoinException>();
        }
    }
}
