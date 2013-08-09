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
    public partial class DiffSelectFrm : Form
    {
        //public enum Difficulty { Easy, Medium, Hard };
        int difficulty;

        public DiffSelectFrm()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            difficulty = 0;
            Form1 frm = new Form1(difficulty);
            frm.Show();
        }
    }
}
