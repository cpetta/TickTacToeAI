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
            Tree moveToMake = new Tree(board, player);
            if (root.children.Count > 0)
            {
                moveToMake = root.children.Last();
            }
            foreach(Tree tree in root.children)
            {
                if (tree.value > moveToMake.value)
                    moveToMake = tree;
            }
            return moveToMake.board;
        }

        public Tree minimax(Tree b, int player)
        {
            // If the game is over either because there's a winner or there are no more empty spaces.
            if (b.board.GameOver)
            {
                b.value = b.board.Winner;
                return b;
            }

            if(player == 0)
            {
                b.value = int.MinValue;
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
            return b;
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
