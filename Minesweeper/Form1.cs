using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        int difficulty;  // 0: easy, 1: medium, 2: hard

        public Form1(int diff)
        {
            difficulty = diff;
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game;

            switch (difficulty)
            {
                case 0:
                    game = new Game(this.pnlMines, 9, 9, 10);
                    game.DrawGrid();
                    break;
                case 1:
                    game = new Game(this.pnlMines, 16, 16, 40);
                    game.DrawGrid();
                    break;
                case 2:
                    game = new Game(this.pnlMines, 16, 16, 40);
                    game.DrawGrid();
                    break;
            }
        }

    }
}
