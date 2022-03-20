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
        private int [,] buttonValues;   // 1 for an X, 0 for an 0 and -1 for empty
        private string [,] textButtonValues;
        public mainForm()
        {
            InitializeComponent();
            buttonValues = new int[3,3] { { -1, -1, -1 },
                                         { - 1, - 1, - 1 },
                                            {-1, - 1 ,- 1 } };
            textButtonValues = new string[3, 3] { { " ", " ", " " },
                                                { " ", " ", " " },
                                                { " ", " ", " " }};
        }

        private void button_Click(object sender, EventArgs e)
        {

            // Get the sender as a Button.
            Button myButton = sender as Button;
            

            switch (myButton.Name)
            {
                case "firstLeftButton":
                    textButtonValues[0, 0] = "X";
                    break;
                case "firstMiddleButton":
                    textButtonValues[0, 1] = "X";
                    break;

                case "firstRightButton":
                    textButtonValues[0, 2] = "X";
                    break;

                case "secondLeftButton":
                    textButtonValues[1, 0] = "X";
                    break;
                case "secondMiddleButton":
                    textButtonValues[1, 1] = "X";
                    break;

                case "secondRightButton":
                    textButtonValues[1, 2] = "X";
                    break;

                case "thirdLeftButton":
                    textButtonValues[2, 0] = "X";
                    break;
                case "thirdMiddleButton":
                    textButtonValues[2, 1] = "X";
                    break;

                case "thirdRightButton":
                    textButtonValues[2, 2] = "X";
                    break;
            }
           

            updateAllButtons();
            disableAllButtons();
        }

        private void updateAllButtons()
        {
            firstLeftButton.Text = textButtonValues[0,0]; 
            firstMiddleButton.Text = textButtonValues[0,1];
            firstRightButton.Text = textButtonValues[0,2];
            secondLeftButton.Text = textButtonValues[1,0];
            secondMiddleButton.Text = textButtonValues[1,1];
            secondRightButton.Text = textButtonValues[1,2];
            thirdLeftButton.Text = textButtonValues[2,0];
            thirdMiddleButton.Text = textButtonValues[2,1];
            thirdRightButton.Text = textButtonValues[2,2];
        }

        private void disableAllButtons()
        {
            firstLeftButton.Enabled = false;
            firstMiddleButton.Enabled = false;
            firstRightButton.Enabled = false;
            secondLeftButton.Enabled = false;
            secondMiddleButton.Enabled = false;
            secondRightButton.Enabled = false;
            thirdLeftButton.Enabled = false;
            thirdMiddleButton.Enabled = false;
            thirdRightButton.Enabled = false;


        }

        private void enableAllButtons()
        {
            firstLeftButton.Enabled = true;
            firstMiddleButton.Enabled = true;
            firstRightButton.Enabled = true;
            secondLeftButton.Enabled = true;
            secondMiddleButton.Enabled = true;
            secondRightButton.Enabled = true;
            thirdLeftButton.Enabled = true;
            thirdMiddleButton.Enabled = true;
            thirdRightButton.Enabled = true;


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
