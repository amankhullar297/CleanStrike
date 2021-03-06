using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanStrikeImpl.Tests
{
    public class GameFixture
    {
        [Fact]
        public void Player1IsWinner_IfPointsMetTheCriteria()
        {
            Utility.ResetBoard();
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.RedStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);

            var output = game.PlayStrikeTurn(StrikeType.Strike);
            output.Should().Be("Player 1 is Winner !!");
        }

        [Fact]
        public void Player2IsWinner_IfPointsMetTheCriteria()
        {
            Utility.ResetBoard();
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.RedStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);

            var output = game.PlayStrikeTurn(StrikeType.Strike);
            output.Should().Be("Player 2 is Winner !!");
        }

        [Fact]
        public void MatchGetsDraw_IfCoinsEnds_AndPointsDoesnotMetCriteria()
        {
            Utility.ResetBoard();
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.RedStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);

            var output = game.PlayStrikeTurn(StrikeType.Strike);
            output.Should().Be("Match is Draw !!");
        }

        [Fact]
        public void NoRedCoinExceptionIsThrown_IfAttemptedForRedCoin_MoreThanCount()
        {
            Utility.ResetBoard();
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.RedStrike);
            game.PlayStrikeTurn(StrikeType.Strike);
            game.PlayStrikeTurn(StrikeType.Strike);

            Action action = () => game.PlayStrikeTurn(StrikeType.RedStrike);
            action.Should().Throw<NoRedCoinException>();
        }
    }
}
