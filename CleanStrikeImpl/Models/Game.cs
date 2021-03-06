using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    public class Game
    {
        private readonly Player Player1;
        private readonly Player Player2;
        private bool IsPlayer1Turn;

        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
            IsPlayer1Turn = true;
        }

        public Game(Player player1, Player player2, int blackCoins, int redCoins) : this (player1, player2)
        {
            CarromBoard.BlackCoins = blackCoins;
            CarromBoard.RedCoins = redCoins;
        }

        public string PlayStrikeTurn(StrikeType strikeType)
        {
            try
            {
                if (IsPlayer1Turn)
                {
                    Player1.Strike(strikeType);
                    IsPlayer1Turn = false;
                    return $"{strikeType.ToString()} from player 1";
                }

                else
                {
                    Player2.Strike(strikeType);
                    IsPlayer1Turn = true;
                    return $"{strikeType.ToString()} from player 2";
                }
            }
            catch (Exception exception)
            {
                if (exception is NoCoinException)
                {
                    var output = DeclareWinner();
                    return output;
                }

                else
                throw exception;
            }
        }

        private string DeclareWinner()
        {
            var pointsDifference = Player1.Points - Player2.Points;
            if (Player1.Points >= 5 || Player2.Points >= 5)
            {
                if (Math.Abs(pointsDifference) >= 3 && pointsDifference > 0)
                    return "Player 1 is Winner !!";

                else if (Math.Abs(pointsDifference) >= 3 && pointsDifference < 0)
                    return "Player 2 is Winner !!";
            }

            return "Match is Draw !!";
        }
    }
}