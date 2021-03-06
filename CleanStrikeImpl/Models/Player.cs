using System;
using System.Collections.Generic;
using System.Text;

namespace CleanStrikeImpl
{
    public class Player
    {
        public string Name { get; set; }
        internal int Points { get; set; }
        internal int Fouls { get; set; }
        internal int SuccessiveNonStrike { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        internal void Strike(StrikeType strikeType)
        {
            var strike = StrikeFactory.GetStrikeType(strikeType);
            CarromBoard.Striker.Strike(this, strike);
        }
    }
}