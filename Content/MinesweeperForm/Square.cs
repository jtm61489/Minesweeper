using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MinesweeperForm
{
    public class Square
    {
        private Button sqr;
        private Game game;

        public Square(Game game, int xPos, int yPos)
        {
            
            sqr = new Button();
            sqr.BackgroundImage = MinesweeperForm.Properties.Resources.ButtonUp;
            sqr.Width = 16;
            sqr.Height = 16;
            sqr.FlatStyle = FlatStyle.Flat;

            sqr.Left = xPos * sqr.Width;
            sqr.Top = yPos * sqr.Height;

            game.panel.Controls.Add(sqr);
        }
        
    }
}
