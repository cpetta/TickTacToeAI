using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    internal class Tree
    {
        public Board board;
        public int playerTurn;
        public int value;

        public Tree Parrent;
        public List<Tree> children = new List<Tree>();
        public Tree(Board b, int turn)
        {
            board = b;
            playerTurn = turn;
        }
        public void addChild(Tree b)
        {
            children.Add(b);
            b.Parrent = this;
        }
        public void setParrent(Tree p)
        {
            Parrent = p;
            p.children.Add(this);
        }
    }
}
