using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace WordAddInTicTacToe
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btCreateTicTacToe_Click(object sender, RibbonControlEventArgs e)
        {
            FormTicTacToe TicTacToeForm = new FormTicTacToe();
            TicTacToeForm.Show();
        }
    }
}
