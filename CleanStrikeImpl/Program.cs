using System;
using System.Collections.Generic;

namespace CleanStrikeImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Aman");
            Player player2 = new Player("Aman2");

            Game game = new Game(player1, player2);
            game.PlayStrikeTurn(StrikeType.MultiStrike);
            game.PlayStrikeTurn(StrikeType.MultiStrike);

            Console.WriteLine(player1.Points);
            Console.WriteLine(player2.Points);
            Console.ReadKey();
        }
    }
}
