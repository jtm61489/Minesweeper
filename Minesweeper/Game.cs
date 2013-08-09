using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{    
    public class Game
    {
        public Panel panel; //shouldnt be public, need a quick fix:  Make getter/setter
        private int row;
        private int col;
        private int mines;
        private Square[,] squares;

        public Game(Panel panel, int row, int col, int mines)
        {
            this.panel = panel;
            this.row = row;
            this.col = col;
            this.mines = mines;
        }

        public void DrawGrid()
        {
            squares = new Square[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Square sqr = new Square(this, i, j);   //this is sending the game, probably can send the panel from game.Panel
                    squares[i, j] = sqr;
                }
        }
    }
}
