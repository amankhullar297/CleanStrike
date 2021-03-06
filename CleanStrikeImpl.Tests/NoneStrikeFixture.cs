using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanStrikeImpl.Tests
{
    public class NoneStrikeFixture
    {
        private readonly NoneStrike NoneStrike = new NoneStrike();

        [Fact]
        public void NoneStrike_WillIncreaseSuccessiveNonStrike_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, NoneStrike, 1);

            player.SuccessiveNonStrike.Should().Be(1);
        }

        [Fact]
        public void NoneStrike_WillDecreaseAdditionalPoint_For3SuccessiveNonStrike_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, NoneStrike, 3);

            player.Points.Should().Be(-1);
        }
    }
}
