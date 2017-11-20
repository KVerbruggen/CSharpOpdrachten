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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYahtzee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelDice = new System.Windows.Forms.FlowLayoutPanel();
            this.btRoll = new System.Windows.Forms.Button();
            this.lblUpper = new System.Windows.Forms.Label();
            this.btUpper1 = new ButtonScore(1);
            this.btUpper2 = new ButtonScore(2);
            this.btUpper3 = new ButtonScore(3);
            this.btUpper4 = new ButtonScore(4);
            this.btUpper5 = new ButtonScore(5);
            this.btUpper6 = new ButtonScore(6);
            this.lblLower = new System.Windows.Forms.Label();
            this.bt3OfAKind = new ButtonScore(ScoreType.THREEOFAKIND);
            this.bt4OfAKind = new ButtonScore(ScoreType.FOUROFAKIND);
            this.btSmallStraight = new ButtonScore(ScoreType.SMALLSTRAIGHT);
            this.btLargeStraight = new ButtonScore(ScoreType.LARGESTRAIGHT);
            this.btFullHouse = new ButtonScore(ScoreType.FULLHOUSE);
            this.btYahtzee = new ButtonScore(ScoreType.YAHTZEE);
            this.btChance = new ButtonScore(ScoreType.CHANCE);
            this.lblTotalScore = new System.Windows.Forms.Label();
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
            // imageListDice
            // 
            this.imageListDice.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListDice.ImageSize = new System.Drawing.Size(50, 50);
            this.imageListDice.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.AllowUserToAddRows = false;
            this.dataGridViewScore.AllowUserToDeleteRows = false;
            this.dataGridViewScore.AllowUserToResizeColumns = false;
            this.dataGridViewScore.AllowUserToResizeRows = false;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScore.DefaultCellStyle = dataGridViewCellStyle1;
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
            // btUpper1
            // 
            this.btUpper1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper1.Enabled = false;
            this.btUpper1.Location = new System.Drawing.Point(16, 179);
            this.btUpper1.Name = "btUpper1";
            this.btUpper1.Size = new System.Drawing.Size(82, 23);
            this.btUpper1.TabIndex = 4;
            this.btUpper1.Text = "1";
            this.btUpper1.UseVisualStyleBackColor = true;
            this.btUpper1.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btUpper2
            // 
            this.btUpper2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper2.Enabled = false;
            this.btUpper2.Location = new System.Drawing.Point(16, 201);
            this.btUpper2.Name = "btUpper2";
            this.btUpper2.Size = new System.Drawing.Size(82, 23);
            this.btUpper2.TabIndex = 5;
            this.btUpper2.Text = "2";
            this.btUpper2.UseVisualStyleBackColor = true;
            this.btUpper2.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btUpper3
            // 
            this.btUpper3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper3.Enabled = false;
            this.btUpper3.Location = new System.Drawing.Point(16, 223);
            this.btUpper3.Name = "btUpper3";
            this.btUpper3.Size = new System.Drawing.Size(82, 23);
            this.btUpper3.TabIndex = 6;
            this.btUpper3.Text = "3";
            this.btUpper3.UseVisualStyleBackColor = true;
            this.btUpper3.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btUpper4
            // 
            this.btUpper4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper4.Enabled = false;
            this.btUpper4.Location = new System.Drawing.Point(16, 245);
            this.btUpper4.Name = "btUpper4";
            this.btUpper4.Size = new System.Drawing.Size(82, 23);
            this.btUpper4.TabIndex = 7;
            this.btUpper4.Text = "4";
            this.btUpper4.UseVisualStyleBackColor = true;
            this.btUpper4.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btUpper5
            // 
            this.btUpper5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper5.Enabled = false;
            this.btUpper5.Location = new System.Drawing.Point(16, 267);
            this.btUpper5.Name = "btUpper5";
            this.btUpper5.Size = new System.Drawing.Size(82, 23);
            this.btUpper5.TabIndex = 8;
            this.btUpper5.Text = "5";
            this.btUpper5.UseVisualStyleBackColor = true;
            this.btUpper5.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btUpper6
            // 
            this.btUpper6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper6.Enabled = false;
            this.btUpper6.Location = new System.Drawing.Point(16, 289);
            this.btUpper6.Name = "btUpper6";
            this.btUpper6.Size = new System.Drawing.Size(82, 23);
            this.btUpper6.TabIndex = 9;
            this.btUpper6.Text = "6";
            this.btUpper6.UseVisualStyleBackColor = true;
            this.btUpper6.Click += new System.EventHandler(this.btScore_Click);
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
            // bt3OfAKind
            // 
            this.bt3OfAKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt3OfAKind.Enabled = false;
            this.bt3OfAKind.Location = new System.Drawing.Point(16, 333);
            this.bt3OfAKind.Name = "bt3OfAKind";
            this.bt3OfAKind.Size = new System.Drawing.Size(82, 23);
            this.bt3OfAKind.TabIndex = 10;
            this.bt3OfAKind.Text = "3 of a Kind";
            this.bt3OfAKind.UseVisualStyleBackColor = true;
            this.bt3OfAKind.Click += new System.EventHandler(this.btScore_Click);
            // 
            // bt4OfAKind
            // 
            this.bt4OfAKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt4OfAKind.Enabled = false;
            this.bt4OfAKind.Location = new System.Drawing.Point(16, 355);
            this.bt4OfAKind.Name = "bt4OfAKind";
            this.bt4OfAKind.Size = new System.Drawing.Size(82, 23);
            this.bt4OfAKind.TabIndex = 11;
            this.bt4OfAKind.Text = "4 of a Kind";
            this.bt4OfAKind.UseVisualStyleBackColor = true;
            this.bt4OfAKind.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btSmallStraight
            // 
            this.btSmallStraight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSmallStraight.Enabled = false;
            this.btSmallStraight.Location = new System.Drawing.Point(16, 377);
            this.btSmallStraight.Name = "btSmallStraight";
            this.btSmallStraight.Size = new System.Drawing.Size(82, 23);
            this.btSmallStraight.TabIndex = 13;
            this.btSmallStraight.Text = "Small Straight";
            this.btSmallStraight.UseVisualStyleBackColor = true;
            this.btSmallStraight.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btLargeStraight
            // 
            this.btLargeStraight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLargeStraight.Enabled = false;
            this.btLargeStraight.Location = new System.Drawing.Point(16, 399);
            this.btLargeStraight.Name = "btLargeStraight";
            this.btLargeStraight.Size = new System.Drawing.Size(82, 23);
            this.btLargeStraight.TabIndex = 14;
            this.btLargeStraight.Text = "Large Straight";
            this.btLargeStraight.UseVisualStyleBackColor = true;
            this.btLargeStraight.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btFullHouse
            // 
            this.btFullHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFullHouse.Enabled = false;
            this.btFullHouse.Location = new System.Drawing.Point(16, 421);
            this.btFullHouse.Name = "btFullHouse";
            this.btFullHouse.Size = new System.Drawing.Size(82, 23);
            this.btFullHouse.TabIndex = 15;
            this.btFullHouse.Text = "Full House";
            this.btFullHouse.UseVisualStyleBackColor = true;
            this.btFullHouse.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btYahtzee
            // 
            this.btYahtzee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btYahtzee.Enabled = false;
            this.btYahtzee.Location = new System.Drawing.Point(16, 443);
            this.btYahtzee.Name = "btYahtzee";
            this.btYahtzee.Size = new System.Drawing.Size(82, 23);
            this.btYahtzee.TabIndex = 16;
            this.btYahtzee.Text = "Yahtzee";
            this.btYahtzee.UseVisualStyleBackColor = true;
            this.btYahtzee.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btChance
            // 
            this.btChance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChance.Enabled = false;
            this.btChance.Location = new System.Drawing.Point(16, 465);
            this.btChance.Name = "btChance";
            this.btChance.Size = new System.Drawing.Size(82, 23);
            this.btChance.TabIndex = 16;
            this.btChance.Text = "Chance";
            this.btChance.UseVisualStyleBackColor = true;
            this.btChance.Click += new System.EventHandler(this.btScore_Click);
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
            // FormYahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(493, 520);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.flowLayoutPanelDice);
            this.Controls.Add(this.btRoll);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.btUpper1);
            this.Controls.Add(this.btUpper2);
            this.Controls.Add(this.btUpper3);
            this.Controls.Add(this.btUpper4);
            this.Controls.Add(this.btUpper5);
            this.Controls.Add(this.btUpper6);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.bt3OfAKind);
            this.Controls.Add(this.bt4OfAKind);
            this.Controls.Add(this.btSmallStraight);
            this.Controls.Add(this.btLargeStraight);
            this.Controls.Add(this.btFullHouse);
            this.Controls.Add(this.btYahtzee);
            this.Controls.Add(this.btChance);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.dataGridViewScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
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
        private System.Windows.Forms.ImageList imageListDice;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDice;
        private System.Windows.Forms.Button btRoll;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.Label lblUpper;
        private ButtonScore btUpper1;
        private ButtonScore btUpper2;
        private ButtonScore btUpper3;
        private ButtonScore btUpper4;
        private ButtonScore btUpper5;
        private ButtonScore btUpper6;
        private System.Windows.Forms.Label lblLower;
        private ButtonScore bt3OfAKind;
        private ButtonScore bt4OfAKind;
        private ButtonScore btSmallStraight;
        private ButtonScore btLargeStraight;
        private ButtonScore btFullHouse;
        private ButtonScore btYahtzee;
        private ButtonScore btChance;
        private System.Windows.Forms.Label lblTotalScore;
    }
}

