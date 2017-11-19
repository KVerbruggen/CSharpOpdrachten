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

        private Dictionary<int, Tuple<PictureBox, CheckBox>> dieControls = new Dictionary<int, Tuple<PictureBox, CheckBox>>();
        private List<Button> scoreButtons = new List<Button>();

        public FormYahtzee()
        {
            // TO-DO: Select columnheader to indicate current player.
            // TO-DO: End game/show winner
            InitializeComponent();
            LoadDieGBs();
            LoadImages();
            LoadButtons();
            InitializeGame();
            removePlayerToolStripMenuItem.Enabled = false;
        }

        private void LoadDieGBs()
        {
            for (int i = 0; i < 5; i++)
            {
                GroupBox gbDie = new GroupBox();
                CheckBox cbDie = new CheckBox();
                PictureBox pbDie = new PictureBox();

                // 
                // gbDie
                // 
                gbDie.Controls.Add(pbDie);
                gbDie.Controls.Add(cbDie);
                gbDie.Location = new System.Drawing.Point(3 + (i * 74), 3);
                gbDie.Name = "gbDie" + (i + 1);
                gbDie.Size = new System.Drawing.Size(68, 89);
                gbDie.TabIndex = i;
                gbDie.TabStop = false;
                // 
                // pbDie
                // 
                pbDie.BackColor = System.Drawing.Color.Transparent;
                pbDie.Image = ((System.Drawing.Image)(this.resources.GetObject("pbDie" + (i + 1) + ".Image")));
                pbDie.Location = new System.Drawing.Point(6, 9);
                pbDie.Name = "pbDie" + (i + 1);
                pbDie.Size = new System.Drawing.Size(50, 50);
                pbDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pbDie.TabIndex = i;
                pbDie.TabStop = false;
                // 
                // cbDie
                // 
                cbDie.AutoSize = true;
                cbDie.Location = new System.Drawing.Point(6, 66);
                cbDie.Name = "cbDie" + (i + 1);
                cbDie.Size = new System.Drawing.Size(50, 17);
                cbDie.TabIndex = i;
                cbDie.Text = "Lock";
                cbDie.UseVisualStyleBackColor = true;
                cbDie.Enabled = false;

                // 
                // flowLayoutPanel1
                // 
                this.flowLayoutPanel1.Controls.Add(gbDie);
                dieControls.Add(i + 1, new Tuple<PictureBox, CheckBox>(pbDie, cbDie));
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

        private void LoadGridViewColumns(int currentAmountOfPlayers, int toAdd)
        {
            for (int i = currentAmountOfPlayers + 1; i <= (currentAmountOfPlayers + toAdd); i++)
            {
                dataGridViewScore.Columns.Add("Player " + i, "Player " + i);
                dataGridViewScore.Columns[dataGridViewScore.Columns.Count - 1].Width = 55;
            }
            addPlayerToolStripMenuItem.Enabled = (Game.NrOfPlayers < 6);
            removePlayerToolStripMenuItem.Enabled = (dataGridViewScore.Columns.Count > 1);

            dataGridViewScore.Width = (55 * Game.NrOfPlayers) + 3;
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
            DisableCheckBoxes();
        }

        private void DisableCheckBoxes()
        {
            foreach (KeyValuePair<int, Tuple<PictureBox, CheckBox>> dieControlPair in dieControls)
            {
                dieControlPair.Value.Item2.Enabled = false;
            }
        }

        private void EnableCheckBoxes()
        {
            foreach (KeyValuePair<int, Tuple<PictureBox, CheckBox>> dieControlPair in dieControls)
            {
                dieControlPair.Value.Item2.Enabled = true;
            }
        }

        private void EnableScoreButtons()
        {
            foreach(Button button in scoreButtons)
            {
                button.Enabled = true;
            }
        }

        private void ResetButtons()
        {
            foreach(Button button in scoreButtons)
            {
                button.Enabled = false;
            }
            DisableCheckBoxes();
            btRoll.Enabled = true;
        }

        private void SetScoreButtons()
        {
            for (int i = 0; i < scoreButtons.Count - 1; i++)
            {
                bool enable = (Game.Scores[Game.CurrentPlayer][i] == null);
                scoreButtons[i].Enabled = enable;
            }
            scoreButtons[scoreButtons.Count - 1].Enabled = true;
        }

        private void ResetGridView()
        {
            dataGridViewScore.Rows.Clear();
            dataGridViewScore.Columns.Clear();

            LoadGridViewColumns(0, Game.NrOfPlayers);
            dataGridViewScore.Rows.Add(15);

            dataGridViewScore.Rows[0].Cells[0].Selected = false;
        }

        private void SetScore(int currentPlayer, ScoreType scoreType, int score, int totalScore)
        {
            int rowNr;
            if ((int)scoreType <= 6)
            {
                rowNr = (int)scoreType;
            }
            else
            {
                rowNr = (int)scoreType + 1;
            }
            dataGridViewScore.Rows[rowNr].Cells[currentPlayer].Value = score;
            dataGridViewScore.Rows[dataGridViewScore.Rows.Count - 1].Cells[currentPlayer].Value = totalScore;
        }

        private void UpdateDice(int?[] dice)
        {
            for (int i = 0; i < 5; i++)
            {
                PictureBox pbDie = dieControls[i + 1].Item1;
                pbDie.Image = imageListDice.Images["die_" + dice[i]];
                if (pbDie.Image == null)
                {
                    pbDie.Image = imageListDice.Images["die_empty"];
                }
            }
        }

        private void AddPlayers(int amount)
        {
            Game.NrOfPlayers += amount;
            LoadGridViewColumns(Game.NrOfPlayers - amount, amount);
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
            }
            removePlayerToolStripMenuItem.Enabled = (dataGridViewScore.Columns.Count > 1);
            addPlayerToolStripMenuItem.Enabled = true;
            dataGridViewScore.Width = (55 * Game.NrOfPlayers) + 3;
        }

        private void StartGame()
        {
            if (!gameFinished)
            {
                EnableScoreButtons();
                gameStarted = true;
            }
            addPlayerToolStripMenuItem.Enabled = false;
            removePlayerToolStripMenuItem.Enabled = false;
        }

        private void EndTurn()
        {
            ResetButtons();
            DisableCheckBoxes();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtons();
            InitializeGame();
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
            if (Game.CurrentRoll == 0)
            {
                UpdateDice(Game.RollDice().Cast<int?>().ToArray());
            }
            else
            {
                bool[] diceToRoll = new bool[5];
                for (int i = 0; i < 5; i++)
                {
                    diceToRoll[i] = !dieControls[i + 1].Item2.Checked;
                }
                UpdateDice(Game.RollDice(diceToRoll).Cast<int?>().ToArray());
            }
            if (Game.CurrentRoll == 3)
            {
                DisableCheckBoxes();
                btRoll.Enabled = false;
            }
            else
            {
                EnableCheckBoxes();
                SetScoreButtons();
            }
        }

        private void btScore_Click(object sender, EventArgs e)
        {
            if(sender is ButtonScore)
            {
                ScoreType scoreType = ((ButtonScore)sender).ScoreType;
                SetScore(Game.CurrentPlayer, scoreType, Game.CalculateScore(scoreType), Game.GetTotalScore(Game.CurrentPlayer));
            }
            EndTurn();
        }
    }
}
