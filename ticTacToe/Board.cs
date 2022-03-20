using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    internal class Board
    {
		public Mark [,] Grid =
		{
			{ new Mark(), new Mark(), new Mark() },
			{ new Mark(), new Mark(), new Mark() },
			{ new Mark(), new Mark() ,new Mark() }
		};
		public Board()
        {

        }
		public Board(Board b)
        {
			Grid = b.Grid;
        }

        public int Winner
        {
            get
            {
                for (int i = 0; i < 3; i++)
                {
                    // Horizontal
                    if (Grid[0, i].charVal == 'X'
                        && Grid[1, i].charVal == 'X'
                        && Grid[2, i].charVal == 'X')
                        return 1;

                    // Vertical
                    if (Grid[i, 0].charVal == 'X'
                        && Grid[i, 1].charVal == 'X'
                        && Grid[i, 2].charVal == 'X')
                        return 1;

                    // Horizontal
                    if (Grid[0, i].charVal == '0'
                        && Grid[1, i].charVal == '0'
                        && Grid[2, i].charVal == '0')
                        return 2;

                    // Vertical
                    if (Grid[i, 0].charVal == '0'
                        && Grid[i, 1].charVal == '0'
                        && Grid[i, 2].charVal == '0')
                        return 2;
                }
                // Diaganal
                if (Grid[0, 0].charVal == 'X'
                    && Grid[1, 1].charVal == 'X'
                    && Grid[2, 2].charVal == 'X')
                    return 1;

                // Diaganal
                if (Grid[0, 2].charVal == 'X'
                    && Grid[1, 1].charVal == 'X'
                    && Grid[2, 0].charVal == 'X')
                    return 1;

                // Diaganal
                if (Grid[0, 0].charVal == '0'
                    && Grid[1, 1].charVal == '0'
                    && Grid[2, 2].charVal == '0')
                    return 2;

                // Diaganal
                if (Grid[0, 2].charVal == '0'
                    && Grid[1, 1].charVal == '0'
                    && Grid[2, 0].charVal == '0')
                    return 2;

                // No winners
                return 0;
            }
        }

        public bool DetectGameOver
        {
            get
            {
                // If someone has already won.
                if (Winner != 0)
                {
                    return true;
                }
                foreach (Mark m in Grid)
                {
                    if (m.charVal == ' ')
                    {
                        // There's still an empty space that can be played on.
                        return false;
                    }
                }
                // There are no more empty spaces.
                return true;
            }
        }
    }
}
