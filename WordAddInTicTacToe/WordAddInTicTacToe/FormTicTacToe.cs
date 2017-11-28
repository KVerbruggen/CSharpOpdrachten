using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordAddInTicTacToe
{
    public partial class FormTicTacToe : Form
    {
        TicTacToe Game;

        private BtTicTacToe[] Buttons = new BtTicTacToe[9];

        // private int lineRotate = 0;

        public FormTicTacToe()
        {
            InitializeComponent();
            Game = new TicTacToe();
            InitializeImages();
            InitializeCells();
            UpdatePlayer();
            pbLine.BackgroundImage = new Bitmap(Properties.Resources.Tic_tac_toe_line);
        }

        /*
        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }
        */

        private void InitializeImages()
        {
            this.imageList.Images.Add(Properties.Resources.Tic_tac_toe_circle);
            this.imageList.Images.Add(Properties.Resources.Tic_tac_toe_cross);
        }

        private void InitializeCells()
        {
            btTicTacToe1.SetCoordinates(0, 0);
            btTicTacToe2.SetCoordinates(1, 0);
            btTicTacToe3.SetCoordinates(2, 0);
            btTicTacToe4.SetCoordinates(0, 1);
            btTicTacToe5.SetCoordinates(1, 1);
            btTicTacToe6.SetCoordinates(2, 1);
            btTicTacToe7.SetCoordinates(0, 2);
            btTicTacToe8.SetCoordinates(1, 2);
            btTicTacToe9.SetCoordinates(2, 2);
            Buttons[0] = btTicTacToe1;
            Buttons[1] = btTicTacToe2;
            Buttons[2] = btTicTacToe3;
            Buttons[3] = btTicTacToe4;
            Buttons[4] = btTicTacToe5;
            Buttons[5] = btTicTacToe6;
            Buttons[6] = btTicTacToe7;
            Buttons[7] = btTicTacToe8;
            Buttons[8] = btTicTacToe9;
        }

        private void SetCells(TicTacToe game)
        {
            for (int i = 0; i < 9; i++)
            {
                int? player = game.Field[i % 3, (int)i / 3];
                if (player == null)
                {
                    Buttons[i].GetButton().BackgroundImage = null;
                }
                else
                {
                    Buttons[i].GetButton().BackgroundImage = imageList.Images[(int)player];
                }
            }
        }

        private void ResetCells()
        {
            foreach (BtTicTacToe button in Buttons)
            {
                button.GetButton().BackgroundImage = null;
                button.GetButton().Enabled = true;
            }
        }

        private void UpdatePlayer()
        {
            pbCurrentPlayer.Image = imageList.Images[Game.CurrentPlayer];
        }

        private void Finish(int? winner = null)
        {
            foreach (BtTicTacToe button in Buttons)
            {
                button.GetButton().Enabled = false;
            }
            if (winner == null)
            {
                lblCurrentPlayer.Text = "It's a draw!";
                pbCurrentPlayer.Image = null;
            }
            else
            {
                lblCurrentPlayer.Text = "Winner: ";
                pbCurrentPlayer.Image = imageList.Images[(int)winner];
            }
            tableLayoutPanelTicTacToe.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
        }

        /*
        private void DrawWinnerLine(int direction, int x, int y)
        {
            switch (direction)
            {
                case 1:
                    // Vertical
                    pbLine.Size = new Size(20, 260);
                    pbLine.Location = new Point(47 + (x * 85), 41);
                    pbLine.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    lineRotate = 0;
                    break;
                case 2:
                    // Horizontal
                    pbLine.Size = new Size(260, 20);
                    pbLine.Location = new Point(12, 76 + (y * 85));
                    lineRotate = 1;
                    break;
                case 3:
                    // Diagonal
                    pbLine.Size = new Size(260, 260);
                    pbLine.Location = new Point(12, 41);
                    lineRotate = 2;
                    RotateImage((Bitmap)pbLine.BackgroundImage, 45);
                    break;
            }
            pbLine.Visible = true;
        }

        private void ResetWinnerLine()
        {
            pbLine.Visible = false;
            pbLine.Size = new Size(260, 20);
            pbLine.Location = new Point(47, -100);
            switch (lineRotate)
            {
                case 1:
                    pbLine.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case 2:
                    break;
                case 3:
                    RotateImage((Bitmap)pbLine.BackgroundImage, 315);
                    break;
            }
            lineRotate = 0;
        }
        */

        private void btRestart_Click(object sender, EventArgs e)
        {
            Game = new TicTacToe();
            // ResetWinnerLine();
            ResetCells();
            tableLayoutPanelTicTacToe.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            lblCurrentPlayer.Text = "Current Player: ";
            UpdatePlayer();
        }

        private void btCell_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(BtTicTacToe)))
            {
                int x = ((BtTicTacToe)sender).Coordinates[0];
                int y = ((BtTicTacToe)sender).Coordinates[1];
                if (Game.Play(x, y))
                {
                    SetCells(Game);
                    int finish = Game.CheckFinish(x, y);
                    switch (finish)
                    {
                        case -1:
                            Finish();
                            break;
                        case 0:
                            Game.EndTurn();
                            UpdatePlayer();
                            break;
                        default:
                            Finish(Game.CurrentPlayer);
                            // DrawWinnerLine(finish, x, y);
                            break;
                    }
                }
            }
        }
    }
}
