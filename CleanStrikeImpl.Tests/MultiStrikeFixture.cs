using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanStrikeImpl.Tests
{
    public class MultiStrikeFixture
    {
        private readonly MultiStrike MultiStrike = new MultiStrike();

        [Fact]
        public void MultiStrike_WillAddMultiplePoint_ForPlayer()
        {
            Player player = new Player("Player 1");

            Utility.ResetBoard();
            Utility.StrikeForNTimes(player, MultiStrike, 1);

            player.Points.Should().Be(2);
        }
    }
}
