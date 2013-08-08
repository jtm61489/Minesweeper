using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinesweeperForm
{
    public partial class Form1 : Form
    {
        enum Difficulty { Easy, Medium, Hard };
        Difficulty diff = Difficulty.Easy;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game;

            switch (diff)
            {
                case Difficulty.Easy:
                    game = new Game(this.pnlMines, 9, 9, 10);
                    game.DrawGrid();
                    break;
                case Difficulty.Medium:
                    game = new Game(this.pnlMines, 16, 16, 40);
                    game.DrawGrid();
                    break;
                case Difficulty.Hard:
                    game = new Game(this.pnlMines, 16, 16, 40);
                    game.DrawGrid();
                    break;
            }
        }

    }
}
