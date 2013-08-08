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

        public Square(Game game, int rowIdx, int colIdx)
        {
            
            sqr = new Button();
            sqr.BackgroundImage = MinesweeperForm.Properties.Resources.ButtonUp;
            sqr.Width = 16;
            sqr.Height = 16;
            sqr.FlatStyle = FlatStyle.Flat;
            sqr.Location = new Point(rowIdx * sqr.Width,  //Location requires (x,y) 
                colIdx * sqr.Height);          //(row number * 16, column number * 16) to keep simple with "blocks" not coords

            game.panel.Controls.Add(sqr);
        }
        
    }
}
