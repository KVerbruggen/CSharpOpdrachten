namespace Yahtzee
{
    partial class FormYahtzee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelDice = new System.Windows.Forms.FlowLayoutPanel();
            this.btRoll = new System.Windows.Forms.Button();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.btScoreUpper1 = new Yahtzee.ButtonScore();
            this.btScoreUpper2 = new Yahtzee.ButtonScore();
            this.btScoreUpper3 = new Yahtzee.ButtonScore();
            this.btScoreUpper4 = new Yahtzee.ButtonScore();
            this.btScoreUpper5 = new Yahtzee.ButtonScore();
            this.btScoreUpper6 = new Yahtzee.ButtonScore();
            this.bt3OfAKind = new Yahtzee.ButtonScore();
            this.bt4OfAKind = new Yahtzee.ButtonScore();
            this.btSmallStraight = new Yahtzee.ButtonScore();
            this.btLargeStraight = new Yahtzee.ButtonScore();
            this.btFullHouse = new Yahtzee.ButtonScore();
            this.btYahtzee = new Yahtzee.ButtonScore();
            this.btChance = new Yahtzee.ButtonScore();
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.matchToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(493, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.addPlayerToolStripMenuItem,
            this.removePlayerToolStripMenuItem});
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.matchToolStripMenuItem.Text = "Match";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Enabled = false;
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removePlayerToolStripMenuItem.Text = "Remove Player";
            this.removePlayerToolStripMenuItem.Click += new System.EventHandler(this.removePlayerToolStripMenuItem_Click);
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.AllowUserToAddRows = false;
            this.dataGridViewScore.AllowUserToDeleteRows = false;
            this.dataGridViewScore.AllowUserToResizeColumns = false;
            this.dataGridViewScore.AllowUserToResizeRows = false;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScore.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewScore.Enabled = false;
            this.dataGridViewScore.Location = new System.Drawing.Point(103, 134);
            this.dataGridViewScore.MultiSelect = false;
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.ReadOnly = true;
            this.dataGridViewScore.RowHeadersVisible = false;
            this.dataGridViewScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridViewScore.Size = new System.Drawing.Size(58, 377);
            this.dataGridViewScore.TabIndex = 20;
            // 
            // flowLayoutPanelDice
            // 
            this.flowLayoutPanelDice.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanelDice.Name = "flowLayoutPanelDice";
            this.flowLayoutPanelDice.Size = new System.Drawing.Size(375, 102);
            this.flowLayoutPanelDice.TabIndex = 21;
            // 
            // btRoll
            // 
            this.btRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRoll.Location = new System.Drawing.Point(390, 35);
            this.btRoll.Name = "btRoll";
            this.btRoll.Size = new System.Drawing.Size(84, 84);
            this.btRoll.TabIndex = 2;
            this.btRoll.Text = "Roll Dice";
            this.btRoll.UseVisualStyleBackColor = true;
            this.btRoll.Click += new System.EventHandler(this.btRoll_Click);
            // 
            // lblUpper
            // 
            this.lblUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.Location = new System.Drawing.Point(15, 163);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(82, 13);
            this.lblUpper.TabIndex = 3;
            this.lblUpper.Text = "Upper scores";
            // 
            // lblLower
            // 
            this.lblLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.Location = new System.Drawing.Point(15, 317);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(82, 13);
            this.lblLower.TabIndex = 12;
            this.lblLower.Text = "Lower scores";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.Location = new System.Drawing.Point(15, 491);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(40, 13);
            this.lblTotalScore.TabIndex = 17;
            this.lblTotalScore.Text = "Total:";
            // 
            // btScoreUpper1
            // 
            this.btScoreUpper1.BackColor = System.Drawing.Color.Transparent;
            this.btScoreUpper1.Location = new System.Drawing.Point(16, 179);
            this.btScoreUpper1.Name = "btScoreUpper1";
            this.btScoreUpper1.ScoreType = Yahtzee.ScoreType.UPPERONE;
            this.btScoreUpper1.Size = new System.Drawing.Size(82, 23);
            this.btScoreUpper1.TabIndex = 22;
            this.btScoreUpper1.Text = "1";
            this.btScoreUpper1.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btScoreUpper2
            // 
            this.btScoreUpper2.BackColor = System.Drawing.Color.Transparent;
            this.btScoreUpper2.Location = new System.Drawing.Point(16, 201);
            this.btScoreUpper2.Name = "btScoreUpper2";
            this.btScoreUpper2.ScoreType = Yahtzee.ScoreType.UPPERTWO;
            this.btScoreUpper2.Size = new System.Drawing.Size(82, 23);
            this.btScoreUpper2.TabIndex = 23;
            this.btScoreUpper2.Text = "2";
            this.btScoreUpper2.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btScoreUpper3
            // 
            this.btScoreUpper3.BackColor = System.Drawing.Color.Transparent;
            this.btScoreUpper3.Location = new System.Drawing.Point(16, 223);
            this.btScoreUpper3.Name = "btScoreUpper3";
            this.btScoreUpper3.ScoreType = Yahtzee.ScoreType.UPPERTHREE;
            this.btScoreUpper3.Size = new System.Drawing.Size(82, 23);
            this.btScoreUpper3.TabIndex = 24;
            this.btScoreUpper3.Text = "3";
            this.btScoreUpper3.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btScoreUpper4
            // 
            this.btScoreUpper4.BackColor = System.Drawing.Color.Transparent;
            this.btScoreUpper4.Location = new System.Drawing.Point(16, 245);
            this.btScoreUpper4.Name = "btScoreUpper4";
            this.btScoreUpper4.ScoreType = Yahtzee.ScoreType.UPPERFOUR;
            this.btScoreUpper4.Size = new System.Drawing.Size(82, 23);
            this.btScoreUpper4.TabIndex = 25;
            this.btScoreUpper4.Text = "4";
            this.btScoreUpper4.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btScoreUpper5
            // 
            this.btScoreUpper5.BackColor = System.Drawing.Color.Transparent;
            this.btScoreUpper5.Location = new System.Drawing.Point(16, 267);
            this.btScoreUpper5.Name = "btScoreUpper5";
            this.btScoreUpper5.ScoreType = Yahtzee.ScoreType.UPPERFIVE;
            this.btScoreUpper5.Size = new System.Drawing.Size(82, 23);
            this.btScoreUpper5.TabIndex = 26;
            this.btScoreUpper5.Text = "5";
            this.btScoreUpper5.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btScoreUpper6
            // 
            this.btScoreUpper6.BackColor = System.Drawing.Color.Transparent;
            this.btScoreUpper6.Location = new System.Drawing.Point(16, 289);
            this.btScoreUpper6.Name = "btScoreUpper6";
            this.btScoreUpper6.ScoreType = Yahtzee.ScoreType.UPPERSIX;
            this.btScoreUpper6.Size = new System.Drawing.Size(82, 23);
            this.btScoreUpper6.TabIndex = 27;
            this.btScoreUpper6.Text = "6";
            this.btScoreUpper6.Click += new System.EventHandler(this.btScore_Click);
            // 
            // bt3OfAKind
            // 
            this.bt3OfAKind.BackColor = System.Drawing.Color.Transparent;
            this.bt3OfAKind.Location = new System.Drawing.Point(16, 333);
            this.bt3OfAKind.Name = "bt3OfAKind";
            this.bt3OfAKind.ScoreType = Yahtzee.ScoreType.THREEOFAKIND;
            this.bt3OfAKind.Size = new System.Drawing.Size(82, 23);
            this.bt3OfAKind.TabIndex = 28;
            this.bt3OfAKind.Text = "3 of a Kind";
            this.bt3OfAKind.Click += new System.EventHandler(this.btScore_Click);
            // 
            // bt4OfAKind
            // 
            this.bt4OfAKind.BackColor = System.Drawing.Color.Transparent;
            this.bt4OfAKind.Location = new System.Drawing.Point(16, 355);
            this.bt4OfAKind.Name = "bt4OfAKind";
            this.bt4OfAKind.ScoreType = Yahtzee.ScoreType.FOUROFAKIND;
            this.bt4OfAKind.Size = new System.Drawing.Size(82, 23);
            this.bt4OfAKind.TabIndex = 29;
            this.bt4OfAKind.Text = "4 of a Kind";
            this.bt4OfAKind.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btSmallStraight
            // 
            this.btSmallStraight.BackColor = System.Drawing.Color.Transparent;
            this.btSmallStraight.Location = new System.Drawing.Point(16, 377);
            this.btSmallStraight.Name = "btSmallStraight";
            this.btSmallStraight.ScoreType = Yahtzee.ScoreType.SMALLSTRAIGHT;
            this.btSmallStraight.Size = new System.Drawing.Size(82, 23);
            this.btSmallStraight.TabIndex = 30;
            this.btSmallStraight.Text = "Small Straight";
            this.btSmallStraight.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btLargeStraight
            // 
            this.btLargeStraight.BackColor = System.Drawing.Color.Transparent;
            this.btLargeStraight.Location = new System.Drawing.Point(16, 399);
            this.btLargeStraight.Name = "btLargeStraight";
            this.btLargeStraight.ScoreType = Yahtzee.ScoreType.LARGESTRAIGHT;
            this.btLargeStraight.Size = new System.Drawing.Size(82, 23);
            this.btLargeStraight.TabIndex = 31;
            this.btLargeStraight.Text = "Large Straight";
            this.btLargeStraight.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btFullHouse
            // 
            this.btFullHouse.BackColor = System.Drawing.Color.Transparent;
            this.btFullHouse.Location = new System.Drawing.Point(16, 421);
            this.btFullHouse.Name = "btFullHouse";
            this.btFullHouse.ScoreType = Yahtzee.ScoreType.FULLHOUSE;
            this.btFullHouse.Size = new System.Drawing.Size(82, 23);
            this.btFullHouse.TabIndex = 32;
            this.btFullHouse.Text = "Full House";
            this.btFullHouse.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btYahtzee
            // 
            this.btYahtzee.BackColor = System.Drawing.Color.Transparent;
            this.btYahtzee.Location = new System.Drawing.Point(16, 443);
            this.btYahtzee.Name = "btYahtzee";
            this.btYahtzee.ScoreType = Yahtzee.ScoreType.YAHTZEE;
            this.btYahtzee.Size = new System.Drawing.Size(82, 23);
            this.btYahtzee.TabIndex = 33;
            this.btYahtzee.Text = "Yahtzee";
            this.btYahtzee.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btChance
            // 
            this.btChance.BackColor = System.Drawing.Color.Transparent;
            this.btChance.Location = new System.Drawing.Point(16, 465);
            this.btChance.Name = "btChance";
            this.btChance.ScoreType = Yahtzee.ScoreType.CHANCE;
            this.btChance.Size = new System.Drawing.Size(82, 23);
            this.btChance.TabIndex = 34;
            this.btChance.Text = "Chance";
            this.btChance.Click += new System.EventHandler(this.btScore_Click);
            // 
            // imageListDice
            // 
            this.imageListDice.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListDice.ImageSize = new System.Drawing.Size(50, 50);
            this.imageListDice.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormYahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(493, 520);
            this.Controls.Add(this.btChance);
            this.Controls.Add(this.btYahtzee);
            this.Controls.Add(this.btFullHouse);
            this.Controls.Add(this.btLargeStraight);
            this.Controls.Add(this.btSmallStraight);
            this.Controls.Add(this.bt4OfAKind);
            this.Controls.Add(this.bt3OfAKind);
            this.Controls.Add(this.btScoreUpper6);
            this.Controls.Add(this.btScoreUpper5);
            this.Controls.Add(this.btScoreUpper4);
            this.Controls.Add(this.btScoreUpper3);
            this.Controls.Add(this.btScoreUpper2);
            this.Controls.Add(this.btScoreUpper1);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.flowLayoutPanelDice);
            this.Controls.Add(this.btRoll);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.dataGridViewScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 534);
            this.Name = "FormYahtzee";
            this.Text = "Yahtzee";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDice;
        private System.Windows.Forms.Button btRoll;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblTotalScore;
        private ButtonScore btScoreUpper1;
        private ButtonScore btScoreUpper2;
        private ButtonScore btScoreUpper3;
        private ButtonScore btScoreUpper4;
        private ButtonScore btScoreUpper5;
        private ButtonScore btScoreUpper6;
        private ButtonScore bt3OfAKind;
        private ButtonScore bt4OfAKind;
        private ButtonScore btSmallStraight;
        private ButtonScore btLargeStraight;
        private ButtonScore btFullHouse;
        private ButtonScore btYahtzee;
        private ButtonScore btChance;
        private System.Windows.Forms.ImageList imageListDice;
    }
}

