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
					board.Grid[0, 0].charVal = 'X';
					break;
				case "firstMiddleButton":
					board.Grid[0, 1].charVal = 'X';
					break;

				case "firstRightButton":
					board.Grid[0, 2].charVal = 'X';
					break;

				case "secondLeftButton":
					board.Grid[1, 0].charVal = 'X';
					break;
				case "secondMiddleButton":
					board.Grid[1, 1].charVal = 'X';
					break;

				case "secondRightButton":
					board.Grid[1, 2].charVal = 'X';
					break;

				case "thirdLeftButton":
					board.Grid[2, 0].charVal = 'X';
					break;
				case "thirdMiddleButton":
					board.Grid[2, 1].charVal = 'X';
					break;

				case "thirdRightButton":
					board.Grid[2, 2].charVal = 'X';
					break;
			}
			updateAllButtons();
			disableAllButtons();
			
			if(board.Winner == 1)
				WinnerLabel.Text = "X Wins";

			if (board.Winner == 2)
				WinnerLabel.Text = "0 Wins";

			if (board.DetectGameOver && board.Winner != 0)
				WinnerLabel.Text = "Draw";
		}

		private void updateAllButtons()
		{
			firstLeftButton.Text    = board.Grid[0, 0].ToString(); 
			firstMiddleButton.Text  = board.Grid[0, 1].ToString();
			firstRightButton.Text   = board.Grid[0, 2].ToString();
			secondLeftButton.Text   = board.Grid[1, 0].ToString();
			secondMiddleButton.Text = board.Grid[1, 1].ToString();
			secondRightButton.Text  = board.Grid[1, 2].ToString();
			thirdLeftButton.Text    = board.Grid[2, 0].ToString();
			thirdMiddleButton.Text  = board.Grid[2, 1].ToString();
			thirdRightButton.Text   = board.Grid[2, 2].ToString();
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
			enableAllButtons();
		}

		private void takeAIturn()
		{

		}
	}
}
