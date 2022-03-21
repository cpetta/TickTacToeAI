using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    internal class AI
    {
        public Board minimax(Board b, int player)
        {
            int player2 = player == 0?1:0;
            List<Board> availableMoves = new List<Board>();

            // If the game is over either because there's a winner or there are no more empty spaces.
            if (b.GameOver)
            {
                return b;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(b.Grid[i, j] == -1)
                    {
                        Board consideration = new Board(b);
                        consideration.Grid[i, j] = player;
                        availableMoves.Add(consideration);
                    }
                }
            }

            Board best = availableMoves.First();
            foreach (Board board in availableMoves)
            {
                if (player == 0)
                {
                    if (minimax(board, player2).Winner > best.Winner)
                        best = board;
                }
                else
                {
                    if (minimax(board, player).Winner > best.Winner)
                        best = board;
                }
            }
            return best;
        }
    }
}
