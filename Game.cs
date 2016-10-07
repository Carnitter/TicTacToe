using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        List<Player> plays = new List<Player>();

        public Game()
        {

        }

        public void update(Player play)
        {
            plays.Add(play);
            hasWon();

        }

        public int hasWon()
        {
            

        }


        
    }
}
