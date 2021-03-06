using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanStrikeImpl.Tests
{
    public class StrikerStrikeFixture
    {
        private readonly StrikerStrike StrikerStrike = new StrikerStrike();

        [Fact]
        public void StrikerStrike_WillDecreasePoint_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, StrikerStrike, 1);

            player.Points.Should().Be(-1);
        }

        [Fact]
        public void StrikerStrike_WillIncreaseFoul_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, StrikerStrike, 1);

            player.Fouls.Should().Be(1);
        }

        [Fact]
        public void StrikerStrike_WillDecreaseAdditionalPoint_For3Fouls_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, StrikerStrike, 3);

            player.Points.Should().Be(-4);
        }
    }
}
