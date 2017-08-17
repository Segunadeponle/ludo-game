using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ssg309Project
{
    class Player
    {
        public Player()
        {
            NumberOfPiecePlayed = 0;
            Turn = false;
        }
        public string Name { get; set; }
        public GameColor Color { get; set; }
        public bool Turn { get; set; }
        public int NumberOfPiecePlayed { get; set; }
    }

    enum GameColor
    {
        Red,Green,Blue,Yellow
    }
}
