using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanStrikeImpl.Tests
{
    public class StrikerFixture
    {
        [Fact]
        public void Striker_WillCallStrikeMethod_OfStrikeTypeOnce()
        {
            var player = new Player("Player 1");
            var strikerMock = new Mock<IStrike>();

            strikerMock.Object.Strike(player);

            strikerMock.Verify(x => x.Strike(It.IsAny<Player>()), Times.Once);
        }
    }
}