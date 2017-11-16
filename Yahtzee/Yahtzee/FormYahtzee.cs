using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class FormYahtzee : Form
    {
        private Yahtzee Game;

        private bool gameStarted;
        private bool gameFinished;

        private List<Button> scoreButtons = new List<Button>();

        public FormYahtzee()
        {
            InitializeComponent();
            LoadImages();
            LoadButtons();
            InitializeGame();
            removePlayerToolStripMenuItem.Enabled = false;
        }

        private void LoadButtons()
        {
            scoreButtons.Add(btUpper1);
            scoreButtons.Add(btUpper2);
            scoreButtons.Add(btUpper3);
            scoreButtons.Add(btUpper4);
            scoreButtons.Add(btUpper5);
            scoreButtons.Add(btUpper6);
            scoreButtons.Add(bt3OfAKind);
            scoreButtons.Add(bt4OfAKind);
            scoreButtons.Add(btSmallStraight);
            scoreButtons.Add(btLargeStraight);
            scoreButtons.Add(btFullHouse);
            scoreButtons.Add(btYahtzee);
        }

        private void InitializeGame()
        {
            gameStarted = false;
            gameFinished = false;
            Game = new Yahtzee();
            UpdateDice(new int?[5]);
            ResetGridView();
        }
        private void ResetGame()
        {
            gameStarted = false;
            gameFinished = false;
            Game = new Yahtzee(Game.NrOfPlayers);
            UpdateDice(new int?[5]);
            ResetGridView();
        }

        private void ResetButtons()
        {
            foreach(Button button in scoreButtons)
            {
                button.Enabled = false;
            }
        }

        private void LoadImages()
        {
            imageListDice.Images.Add("die_empty", Properties.Resources.die_empty);
            imageListDice.Images.Add("die_1", Properties.Resources.die_1);
            imageListDice.Images.Add("die_2", Properties.Resources.die_2);
            imageListDice.Images.Add("die_3", Properties.Resources.die_3);
            imageListDice.Images.Add("die_4", Properties.Resources.die_4);
            imageListDice.Images.Add("die_5", Properties.Resources.die_5);
            imageListDice.Images.Add("die_6", Properties.Resources.die_6);
        }

        private void ResetGridView()
        {
            dataGridViewScore.Rows.Clear();
            dataGridViewScore.Columns.Clear();
            Game.NrOfPlayers = 0;
            AddPlayers(1);
            dataGridViewScore.Rows.Add(15);
            dataGridViewScore.Rows[0].Cells[0].Selected = false;
        }

        private void UpdateDice(int?[] dice)
        {
            for (int i = 0; i < 5; i++)
            {
                GroupBox gbDie = (GroupBox)panelDice.Controls.Find("gbDie" + (i + 1), true)[0];
                PictureBox pbDie = (PictureBox)gbDie.Controls.Find("pbDie" + (i + 1), true)[0];
                pbDie.Image = imageListDice.Images["die_" + dice[i]];
                if (pbDie.Image == null)
                {
                    pbDie.Image = imageListDice.Images["die_empty"];
                }
            }
        }

        private void AddPlayers(int amount)
        {
            for (int i = 0; i < amount; i++) {
                Game.NrOfPlayers++;
                while (Game.NrOfPlayers > dataGridViewScore.Columns.Count)
                {
                    dataGridViewScore.Columns.Add("Player " + Game.NrOfPlayers, "Player " + Game.NrOfPlayers);
                    dataGridViewScore.Columns[dataGridViewScore.Columns.Count - 1].Width = 55;
                }
            }
            if (Game.NrOfPlayers > 5)
            {
                addPlayerToolStripMenuItem.Enabled = false;
            }
            dataGridViewScore.Width = (55 * Game.NrOfPlayers) + 3;
            removePlayerToolStripMenuItem.Enabled = true;
        }

        private void RemovePlayers(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (dataGridViewScore.Columns.Count > 1) {
                    Game.NrOfPlayers--;
                    while (Game.NrOfPlayers < dataGridViewScore.Columns.Count)
                    {
                        dataGridViewScore.Columns.Remove(dataGridViewScore.Columns[dataGridViewScore.Columns.Count - 1]);
                    }
                }
                else
                {
                    removePlayerToolStripMenuItem.Enabled = false;
                }
            }
            addPlayerToolStripMenuItem.Enabled = true;
            dataGridViewScore.Width = (55 * Game.NrOfPlayers) + 3;
        }

        private void StartGame()
        {
            if (!gameFinished)
            {
                foreach (Button button in scoreButtons)
                {
                    button.Enabled = true;
                }
                gameStarted = true;
            }
            addPlayerToolStripMenuItem.Enabled = false;
            removePlayerToolStripMenuItem.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtons();
            ResetGame();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlayers(1);
        }

        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePlayers(1);
        }

        private void btRoll_Click(object sender, EventArgs e)
        {
            if (gameFinished)
            {
                ResetGame();
            }
            if (!gameStarted)
            {
                StartGame();
            }
            UpdateDice(Game.RollDice().Cast<int?>().ToArray());
        }

        private void btUpper1_Click(object sender, EventArgs e)
        {

        }

        private void btUpper2_Click(object sender, EventArgs e)
        {

        }

        private void btUpper3_Click(object sender, EventArgs e)
        {

        }

        private void btUpper4_Click(object sender, EventArgs e)
        {

        }

        private void btUpper5_Click(object sender, EventArgs e)
        {

        }

        private void btUpper6_Click(object sender, EventArgs e)
        {

        }

        private void bt3OfAKind_Click(object sender, EventArgs e)
        {

        }

        private void bt4OfAKind_Click(object sender, EventArgs e)
        {

        }

        private void btSmallStraight_Click(object sender, EventArgs e)
        {

        }

        private void btLargeStraight_Click(object sender, EventArgs e)
        {

        }

        private void btFullHouse_Click(object sender, EventArgs e)
        {

        }

        private void btYahtzee_Click(object sender, EventArgs e)
        {

        }
    }
}
