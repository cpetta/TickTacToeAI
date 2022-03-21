using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    internal class Board
    {
        // 0 for O's, 1 for X's, and -1 for empty.
		public int[,] Grid =
		{
            {-1, -1, -1 },
            {-1, -1, -1 },
            {-1, -1, -1 }
        };
		public Board()
        {

        }
		public Board(Board b)
        {
            Grid = (int[,])b.Grid.Clone();
        }

        // Return 0 for AI Loss, 1 for Draw, 2 for AI win.
        public int Winner
        {
            get
            {
                for (int i = 0; i < 3; i++)
                {
                    // Horizontal
                    if (Grid[0, i] == 1
                        && Grid[1, i] == 1
                        && Grid[2, i] == 1)
                        return 0;

                    // Vertical
                    if (Grid[i, 0] == 1
                        && Grid[i, 1] == 1
                        && Grid[i, 2] == 1)
                        return 0;

                    // Horizontal
                    if (Grid[0, i] == 0
                        && Grid[1, i] == 0
                        && Grid[2, i] == 0)
                        return 2;

                    // Vertical
                    if (Grid[i, 0] == 0
                        && Grid[i, 1] == 0
                        && Grid[i, 2] == 0)
                        return 2;
                }
                // Diaganal
                if (Grid[0, 0] == 1
                    && Grid[1, 1] == 1
                    && Grid[2, 2] == 1)
                    return 0;

                // Diaganal
                if (Grid[0, 2] == 1
                    && Grid[1, 1] == 1
                    && Grid[2, 0] == 1)
                    return 0;

                // Diaganal
                if (Grid[0, 0] == 0
                    && Grid[1, 1] == 0
                    && Grid[2, 2] == 0)
                    return 2;

                // Diaganal
                if (Grid[0, 2] == 0
                    && Grid[1, 1] == 0
                    && Grid[2, 0] == 0)
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
                if (Winner != 1)
                {
                    return true;
                }
                foreach (int i in Grid)
                {
                    if (i == -1)
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
                        if(Grid[i, j] == -1)
                        {
                            int[] arr = {i,j};
                            spaces.Add(arr);
                        }
                    }
                }
                return spaces;
            }
        }

        public bool GameOver
        {
            get
            {
                if (Winner == 0 || Winner == 2 || (DetectGameOver && Winner != 0 && Winner != 2))
                    return true;
                else
                    return false;
            }
        }
    }
}
