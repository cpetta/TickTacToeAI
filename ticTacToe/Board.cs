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

        // Return 0 for AI Loss, 1 for Draw, 2 for AI win.
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
                        return 0;

                    // Vertical
                    if (Grid[i, 0].charVal == 'X'
                        && Grid[i, 1].charVal == 'X'
                        && Grid[i, 2].charVal == 'X')
                        return 0;

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
                    return 0;

                // Diaganal
                if (Grid[0, 2].charVal == 'X'
                    && Grid[1, 1].charVal == 'X'
                    && Grid[2, 0].charVal == 'X')
                    return 0;

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
                return 1;
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

        public List<int[]> EmptySpaces
        {
            get {
                List<int[]> spaces = new List<int[]>();

                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        if(Grid[i, j].charVal == ' ')
                        {
                            int[] arr = {i,j};
                            spaces.Add(arr);
                        }
                    }
                }
                return spaces;
            }
        }
    }
}
