using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    internal class AI
    {
        public Board makeMove(Board board, int player)
        {
            Tree root = new Tree(board, player);
            root = buildTree(root, player);
            minimax(root, player);
            Board moveTomake = root.children.Last().board;
            foreach(Tree tree in root.children)
            {
                if()
            }
            return minimax(root, player).board;
        }

        public Tree minimax(Tree b, int player)
        {
            // If the game is over either because there's a winner or there are no more empty spaces.
            if (b.board.GameOver)
            {
                return b.board;
            }

            if(player == 0)
            {
                b.value = int.MaxValue;
                foreach(Tree child in b.children)
                {
                    b.value =  Math.Max(b.value, minimax(child, 1).value);
                }
            }
            else
            {
                b.value = int.MaxValue;
                foreach (Tree child in b.children)
                {
                    b.value = Math.Min(b.value, minimax(child, 0).value);
                }
            }


            foreach (Tree board in b.children)
            {
                if (player == 0)
                {
                    if (minimax(board, 1).Winner > moveToMake.Winner)
                        moveToMake = board;
                }
                else
                {
                    if (minimax(board, 0).Winner < moveToMake.Winner)
                        moveToMake = board;
                }
            }
            return moveToMake;
        }

        private Tree buildTree(Tree b, int player)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (b.board.Grid[i, j] == -1)
                    {
                        Board consideration = new Board(b.board);
                        consideration.Grid[i, j] = player;
                        Tree node = new Tree(consideration, player == 1 ? 0 : 1);
                        b.addChild(node);
                        buildTree(node, player==1 ? 0 : 1);
                    }
                }
            }
            return b;
        }
    }
}
