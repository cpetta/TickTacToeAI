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

		private string[,] textButtonValues = new string[3, 3]
		{
			{ " ", " ", " " },
			{ " ", " ", " " },
			{ " ", " ", " " }
		};
    }
}
