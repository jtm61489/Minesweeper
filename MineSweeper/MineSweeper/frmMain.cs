using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{

    public partial class frmMain : Form
    {
        //create game difficulty variable
        int varGameDifficulty = 0;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            //leave game difficulty variable default
            //open the game form
            frmGame f2 = new frmGame();
            f2.Show();

            frmMain f1 = (frmMain)Application.OpenForms["frmMain"];
            f1.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            //set game difficulty variable
            int varGameDifficulty = 1;

            //open the game form
            frmGame f2 = new frmGame();
            f2.Show();

            frmMain f1 = new frmMain();
            f1.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            //set game difficulty variable
            int varGameDifficulty = 2;

            //open the game form
            frmGame f2 = new frmGame();
            f2.Show();

            frmMain f1 = new frmMain();
            f1.Close();
        }
    }
}
