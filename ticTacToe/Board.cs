using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    internal class Board
    {
		// 1 for an X, 0 for an 0 and -1 for empty
		private int [,] board =
		{
			{ -1, -1, -1 },
			{ -1, -1, -1 },
			{ -1, -1 ,-1 }
		};

		public int[,] getBoardInt()
        {
			return board;
        }

		public char[,] getBoardChar()
		{
			char[,] charBoard = new char[3, 3];

			for(int i = 0; i < 3; i++)
            {
				for (int j = 0; j < 3 ; j++)
                {
					charBoard[i, j] = getPosChar(i, j);
                }
            }
			return charBoard;
		}

		public int getPosInt(int x,int y)
        {
			return board[x,y];
        }

		public char getPosChar(int x, int y)
        {
			if (board[x, y] == 0)
				return '0';
			else if (board[x, y] == 1)
				return 'X';
			else
				return ' ';
		}
    }
}
