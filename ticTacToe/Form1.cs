using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
	public partial class mainForm : Form
	{
		private Board board = new Board();
		public mainForm()
		{
			InitializeComponent();
		}

		// Human Player Button Press
		private void button_Click(object sender, EventArgs e)
		{
			// Get the sender as a Button.
			Button myButton = sender as Button;
			
			switch (myButton.Name)
			{
				case "firstLeftButton":
					board.Grid[0, 0] = 1;
					break;
				case "firstMiddleButton":
					board.Grid[0, 1] = 1;
					break;

				case "firstRightButton":
					board.Grid[0, 2] = 1;
					break;

				case "secondLeftButton":
					board.Grid[1, 0] = 1;
					break;
				case "secondMiddleButton":
					board.Grid[1, 1] = 1;
					break;

				case "secondRightButton":
					board.Grid[1, 2] = 1;
					break;

				case "thirdLeftButton":
					board.Grid[2, 0] = 1;
					break;
				case "thirdMiddleButton":
					board.Grid[2, 1] = 1;
					break;

				case "thirdRightButton":
					board.Grid[2, 2] = 1;
					break;
			}
			updateAllButtons();
			disableAllButtons();
			updateWinnerLabel();
		}

		private void updateAllButtons()
		{
			firstLeftButton.Text    = ConvertToString(board.Grid[0, 0]);
			firstMiddleButton.Text  = ConvertToString(board.Grid[0, 1]);
			firstRightButton.Text   = ConvertToString(board.Grid[0, 2]);
			secondLeftButton.Text   = ConvertToString(board.Grid[1, 0]);
			secondMiddleButton.Text = ConvertToString(board.Grid[1, 1]);
			secondRightButton.Text  = ConvertToString(board.Grid[1, 2]);
			thirdLeftButton.Text    = ConvertToString(board.Grid[2, 0]);
			thirdMiddleButton.Text  = ConvertToString(board.Grid[2, 1]);
			thirdRightButton.Text   = ConvertToString(board.Grid[2, 2]);
		}

		private void disableAllButtons()
		{
			firstLeftButton.Enabled    = false;
			firstMiddleButton.Enabled  = false;
			firstRightButton.Enabled   = false;
			secondLeftButton.Enabled   = false;
			secondMiddleButton.Enabled = false;
			secondRightButton.Enabled  = false;
			thirdLeftButton.Enabled    = false;
			thirdMiddleButton.Enabled  = false;
			thirdRightButton.Enabled   = false;
		}

		private void enableAllButtons()
		{
			firstLeftButton.Enabled    = true;
			firstMiddleButton.Enabled  = true;
			firstRightButton.Enabled   = true;
			secondLeftButton.Enabled   = true;
			secondMiddleButton.Enabled = true;
			secondRightButton.Enabled  = true;
			thirdLeftButton.Enabled    = true;
			thirdMiddleButton.Enabled  = true;
			thirdRightButton.Enabled   = true;
		}

		private void aiButton_Click(object sender, EventArgs e)
		{
			takeAIturn();
			updateAllButtons();
			enableAllButtons();
			updateWinnerLabel();
		}

		private void takeAIturn()
		{
			AI ai = new AI();
			board = ai.minimax(board, 0);
		}

		private void updateWinnerLabel()
        {
			if (board.Winner == 0)
				WinnerLabel.Text = "X Wins";

			if (board.Winner == 2)
				WinnerLabel.Text = "0 Wins";

			if (board.DetectGameOver && board.Winner != 0 && board.Winner != 2)
				WinnerLabel.Text = "Draw";
		}

		private string ConvertToString(int i)
        {
			if (i == -1)
				return " ";
			else if (i == 0)
				return "0";
			else return "X";
        }
	}
}
