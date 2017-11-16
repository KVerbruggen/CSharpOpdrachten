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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDie5 = new System.Windows.Forms.GroupBox();
            this.pbDie5 = new System.Windows.Forms.PictureBox();
            this.cbDie5 = new System.Windows.Forms.CheckBox();
            this.gbDie4 = new System.Windows.Forms.GroupBox();
            this.pbDie4 = new System.Windows.Forms.PictureBox();
            this.cbDie4 = new System.Windows.Forms.CheckBox();
            this.gbDie3 = new System.Windows.Forms.GroupBox();
            this.pbDie3 = new System.Windows.Forms.PictureBox();
            this.cbDie3 = new System.Windows.Forms.CheckBox();
            this.gbDie2 = new System.Windows.Forms.GroupBox();
            this.pbDie2 = new System.Windows.Forms.PictureBox();
            this.cbDie2 = new System.Windows.Forms.CheckBox();
            this.gbDie1 = new System.Windows.Forms.GroupBox();
            this.pbDie1 = new System.Windows.Forms.PictureBox();
            this.cbDie1 = new System.Windows.Forms.CheckBox();
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.panelDice = new System.Windows.Forms.Panel();
            this.btRoll = new System.Windows.Forms.Button();
            this.btUpper1 = new System.Windows.Forms.Button();
            this.btUpper2 = new System.Windows.Forms.Button();
            this.lblUpper = new System.Windows.Forms.Label();
            this.btUpper3 = new System.Windows.Forms.Button();
            this.btUpper6 = new System.Windows.Forms.Button();
            this.btUpper5 = new System.Windows.Forms.Button();
            this.btUpper4 = new System.Windows.Forms.Button();
            this.btYahtzee = new System.Windows.Forms.Button();
            this.btFullHouse = new System.Windows.Forms.Button();
            this.btLargeStraight = new System.Windows.Forms.Button();
            this.btSmallStraight = new System.Windows.Forms.Button();
            this.lblLower = new System.Windows.Forms.Label();
            this.bt4OfAKind = new System.Windows.Forms.Button();
            this.bt3OfAKind = new System.Windows.Forms.Button();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.gbDie5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie5)).BeginInit();
            this.gbDie4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie4)).BeginInit();
            this.gbDie3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie3)).BeginInit();
            this.gbDie2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie2)).BeginInit();
            this.gbDie1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.panelDice.SuspendLayout();
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
            // gbDie5
            // 
            this.gbDie5.Controls.Add(this.pbDie5);
            this.gbDie5.Controls.Add(this.cbDie5);
            this.gbDie5.Location = new System.Drawing.Point(302, 5);
            this.gbDie5.Name = "gbDie5";
            this.gbDie5.Size = new System.Drawing.Size(68, 89);
            this.gbDie5.TabIndex = 5;
            this.gbDie5.TabStop = false;
            // 
            // pbDie5
            // 
            this.pbDie5.BackColor = System.Drawing.Color.Transparent;
            this.pbDie5.Image = ((System.Drawing.Image)(resources.GetObject("pbDie5.Image")));
            this.pbDie5.Location = new System.Drawing.Point(6, 9);
            this.pbDie5.Name = "pbDie5";
            this.pbDie5.Size = new System.Drawing.Size(50, 50);
            this.pbDie5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDie5.TabIndex = 1;
            this.pbDie5.TabStop = false;
            // 
            // cbDie5
            // 
            this.cbDie5.AutoSize = true;
            this.cbDie5.Location = new System.Drawing.Point(6, 66);
            this.cbDie5.Name = "cbDie5";
            this.cbDie5.Size = new System.Drawing.Size(50, 17);
            this.cbDie5.TabIndex = 0;
            this.cbDie5.Text = "Lock";
            this.cbDie5.UseVisualStyleBackColor = true;
            // 
            // gbDie4
            // 
            this.gbDie4.Controls.Add(this.pbDie4);
            this.gbDie4.Controls.Add(this.cbDie4);
            this.gbDie4.Location = new System.Drawing.Point(228, 5);
            this.gbDie4.Name = "gbDie4";
            this.gbDie4.Size = new System.Drawing.Size(68, 89);
            this.gbDie4.TabIndex = 5;
            this.gbDie4.TabStop = false;
            // 
            // pbDie4
            // 
            this.pbDie4.BackColor = System.Drawing.Color.Transparent;
            this.pbDie4.Image = ((System.Drawing.Image)(resources.GetObject("pbDie4.Image")));
            this.pbDie4.Location = new System.Drawing.Point(6, 9);
            this.pbDie4.Name = "pbDie4";
            this.pbDie4.Size = new System.Drawing.Size(50, 50);
            this.pbDie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDie4.TabIndex = 1;
            this.pbDie4.TabStop = false;
            // 
            // cbDie4
            // 
            this.cbDie4.AutoSize = true;
            this.cbDie4.Location = new System.Drawing.Point(6, 66);
            this.cbDie4.Name = "cbDie4";
            this.cbDie4.Size = new System.Drawing.Size(50, 17);
            this.cbDie4.TabIndex = 0;
            this.cbDie4.Text = "Lock";
            this.cbDie4.UseVisualStyleBackColor = true;
            // 
            // gbDie3
            // 
            this.gbDie3.Controls.Add(this.pbDie3);
            this.gbDie3.Controls.Add(this.cbDie3);
            this.gbDie3.Location = new System.Drawing.Point(154, 5);
            this.gbDie3.Name = "gbDie3";
            this.gbDie3.Size = new System.Drawing.Size(68, 89);
            this.gbDie3.TabIndex = 4;
            this.gbDie3.TabStop = false;
            // 
            // pbDie3
            // 
            this.pbDie3.BackColor = System.Drawing.Color.Transparent;
            this.pbDie3.Image = ((System.Drawing.Image)(resources.GetObject("pbDie3.Image")));
            this.pbDie3.Location = new System.Drawing.Point(6, 9);
            this.pbDie3.Name = "pbDie3";
            this.pbDie3.Size = new System.Drawing.Size(50, 50);
            this.pbDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDie3.TabIndex = 1;
            this.pbDie3.TabStop = false;
            // 
            // cbDie3
            // 
            this.cbDie3.AutoSize = true;
            this.cbDie3.Location = new System.Drawing.Point(6, 66);
            this.cbDie3.Name = "cbDie3";
            this.cbDie3.Size = new System.Drawing.Size(50, 17);
            this.cbDie3.TabIndex = 0;
            this.cbDie3.Text = "Lock";
            this.cbDie3.UseVisualStyleBackColor = true;
            // 
            // gbDie2
            // 
            this.gbDie2.Controls.Add(this.pbDie2);
            this.gbDie2.Controls.Add(this.cbDie2);
            this.gbDie2.Location = new System.Drawing.Point(80, 5);
            this.gbDie2.Name = "gbDie2";
            this.gbDie2.Size = new System.Drawing.Size(68, 89);
            this.gbDie2.TabIndex = 3;
            this.gbDie2.TabStop = false;
            // 
            // pbDie2
            // 
            this.pbDie2.BackColor = System.Drawing.Color.Transparent;
            this.pbDie2.Image = ((System.Drawing.Image)(resources.GetObject("pbDie2.Image")));
            this.pbDie2.Location = new System.Drawing.Point(6, 9);
            this.pbDie2.Name = "pbDie2";
            this.pbDie2.Size = new System.Drawing.Size(50, 50);
            this.pbDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDie2.TabIndex = 1;
            this.pbDie2.TabStop = false;
            // 
            // cbDie2
            // 
            this.cbDie2.AutoSize = true;
            this.cbDie2.Location = new System.Drawing.Point(6, 66);
            this.cbDie2.Name = "cbDie2";
            this.cbDie2.Size = new System.Drawing.Size(50, 17);
            this.cbDie2.TabIndex = 0;
            this.cbDie2.Text = "Lock";
            this.cbDie2.UseVisualStyleBackColor = true;
            // 
            // gbDie1
            // 
            this.gbDie1.Controls.Add(this.pbDie1);
            this.gbDie1.Controls.Add(this.cbDie1);
            this.gbDie1.Location = new System.Drawing.Point(6, 5);
            this.gbDie1.Name = "gbDie1";
            this.gbDie1.Size = new System.Drawing.Size(68, 89);
            this.gbDie1.TabIndex = 2;
            this.gbDie1.TabStop = false;
            // 
            // pbDie1
            // 
            this.pbDie1.BackColor = System.Drawing.Color.Transparent;
            this.pbDie1.Image = ((System.Drawing.Image)(resources.GetObject("pbDie1.Image")));
            this.pbDie1.Location = new System.Drawing.Point(6, 9);
            this.pbDie1.Name = "pbDie1";
            this.pbDie1.Size = new System.Drawing.Size(50, 50);
            this.pbDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDie1.TabIndex = 1;
            this.pbDie1.TabStop = false;
            // 
            // cbDie1
            // 
            this.cbDie1.AutoSize = true;
            this.cbDie1.Location = new System.Drawing.Point(6, 66);
            this.cbDie1.Name = "cbDie1";
            this.cbDie1.Size = new System.Drawing.Size(50, 17);
            this.cbDie1.TabIndex = 0;
            this.cbDie1.Text = "Lock";
            this.cbDie1.UseVisualStyleBackColor = true;
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
            this.dataGridViewScore.Enabled = false;
            this.dataGridViewScore.Location = new System.Drawing.Point(99, 132);
            this.dataGridViewScore.MultiSelect = false;
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.ReadOnly = true;
            this.dataGridViewScore.RowHeadersVisible = false;
            this.dataGridViewScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewScore.Size = new System.Drawing.Size(58, 355);
            this.dataGridViewScore.TabIndex = 20;
            // 
            // panelDice
            // 
            this.panelDice.Controls.Add(this.gbDie5);
            this.panelDice.Controls.Add(this.gbDie4);
            this.panelDice.Controls.Add(this.gbDie3);
            this.panelDice.Controls.Add(this.gbDie2);
            this.panelDice.Controls.Add(this.gbDie1);
            this.panelDice.Location = new System.Drawing.Point(12, 27);
            this.panelDice.Name = "panelDice";
            this.panelDice.Size = new System.Drawing.Size(379, 99);
            this.panelDice.TabIndex = 1;
            // 
            // btRoll
            // 
            this.btRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRoll.Location = new System.Drawing.Point(397, 37);
            this.btRoll.Name = "btRoll";
            this.btRoll.Size = new System.Drawing.Size(84, 84);
            this.btRoll.TabIndex = 2;
            this.btRoll.Text = "Roll Dice";
            this.btRoll.UseVisualStyleBackColor = true;
            this.btRoll.Click += new System.EventHandler(this.btRoll_Click);
            // 
            // btUpper1
            // 
            this.btUpper1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper1.Enabled = false;
            this.btUpper1.Location = new System.Drawing.Point(18, 177);
            this.btUpper1.Name = "btUpper1";
            this.btUpper1.Size = new System.Drawing.Size(80, 23);
            this.btUpper1.TabIndex = 4;
            this.btUpper1.Text = "1";
            this.btUpper1.UseVisualStyleBackColor = true;
            this.btUpper1.Click += new System.EventHandler(this.btUpper1_Click);
            // 
            // btUpper2
            // 
            this.btUpper2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper2.Enabled = false;
            this.btUpper2.Location = new System.Drawing.Point(18, 199);
            this.btUpper2.Name = "btUpper2";
            this.btUpper2.Size = new System.Drawing.Size(80, 23);
            this.btUpper2.TabIndex = 5;
            this.btUpper2.Text = "2";
            this.btUpper2.UseVisualStyleBackColor = true;
            this.btUpper2.Click += new System.EventHandler(this.btUpper2_Click);
            // 
            // lblUpper
            // 
            this.lblUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.Location = new System.Drawing.Point(15, 161);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(82, 13);
            this.lblUpper.TabIndex = 3;
            this.lblUpper.Text = "Upper scores";
            // 
            // btUpper3
            // 
            this.btUpper3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper3.Enabled = false;
            this.btUpper3.Location = new System.Drawing.Point(18, 221);
            this.btUpper3.Name = "btUpper3";
            this.btUpper3.Size = new System.Drawing.Size(80, 23);
            this.btUpper3.TabIndex = 6;
            this.btUpper3.Text = "3";
            this.btUpper3.UseVisualStyleBackColor = true;
            this.btUpper3.Click += new System.EventHandler(this.btUpper3_Click);
            // 
            // btUpper6
            // 
            this.btUpper6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper6.Enabled = false;
            this.btUpper6.Location = new System.Drawing.Point(18, 287);
            this.btUpper6.Name = "btUpper6";
            this.btUpper6.Size = new System.Drawing.Size(80, 23);
            this.btUpper6.TabIndex = 9;
            this.btUpper6.Text = "6";
            this.btUpper6.UseVisualStyleBackColor = true;
            this.btUpper6.Click += new System.EventHandler(this.btUpper6_Click);
            // 
            // btUpper5
            // 
            this.btUpper5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper5.Enabled = false;
            this.btUpper5.Location = new System.Drawing.Point(18, 265);
            this.btUpper5.Name = "btUpper5";
            this.btUpper5.Size = new System.Drawing.Size(80, 23);
            this.btUpper5.TabIndex = 8;
            this.btUpper5.Text = "5";
            this.btUpper5.UseVisualStyleBackColor = true;
            this.btUpper5.Click += new System.EventHandler(this.btUpper5_Click);
            // 
            // btUpper4
            // 
            this.btUpper4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUpper4.Enabled = false;
            this.btUpper4.Location = new System.Drawing.Point(18, 243);
            this.btUpper4.Name = "btUpper4";
            this.btUpper4.Size = new System.Drawing.Size(80, 23);
            this.btUpper4.TabIndex = 7;
            this.btUpper4.Text = "4";
            this.btUpper4.UseVisualStyleBackColor = true;
            this.btUpper4.Click += new System.EventHandler(this.btUpper4_Click);
            // 
            // btYahtzee
            // 
            this.btYahtzee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btYahtzee.Enabled = false;
            this.btYahtzee.Location = new System.Drawing.Point(18, 441);
            this.btYahtzee.Name = "btYahtzee";
            this.btYahtzee.Size = new System.Drawing.Size(80, 23);
            this.btYahtzee.TabIndex = 16;
            this.btYahtzee.Text = "Yahtzee";
            this.btYahtzee.UseVisualStyleBackColor = true;
            this.btYahtzee.Click += new System.EventHandler(this.btYahtzee_Click);
            // 
            // btFullHouse
            // 
            this.btFullHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFullHouse.Enabled = false;
            this.btFullHouse.Location = new System.Drawing.Point(18, 419);
            this.btFullHouse.Name = "btFullHouse";
            this.btFullHouse.Size = new System.Drawing.Size(80, 23);
            this.btFullHouse.TabIndex = 15;
            this.btFullHouse.Text = "Full House";
            this.btFullHouse.UseVisualStyleBackColor = true;
            this.btFullHouse.Click += new System.EventHandler(this.btFullHouse_Click);
            // 
            // btLargeStraight
            // 
            this.btLargeStraight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLargeStraight.Enabled = false;
            this.btLargeStraight.Location = new System.Drawing.Point(18, 397);
            this.btLargeStraight.Name = "btLargeStraight";
            this.btLargeStraight.Size = new System.Drawing.Size(80, 23);
            this.btLargeStraight.TabIndex = 14;
            this.btLargeStraight.Text = "Large Straight";
            this.btLargeStraight.UseVisualStyleBackColor = true;
            this.btLargeStraight.Click += new System.EventHandler(this.btLargeStraight_Click);
            // 
            // btSmallStraight
            // 
            this.btSmallStraight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSmallStraight.Enabled = false;
            this.btSmallStraight.Location = new System.Drawing.Point(18, 375);
            this.btSmallStraight.Name = "btSmallStraight";
            this.btSmallStraight.Size = new System.Drawing.Size(80, 23);
            this.btSmallStraight.TabIndex = 13;
            this.btSmallStraight.Text = "Small Straight";
            this.btSmallStraight.UseVisualStyleBackColor = true;
            this.btSmallStraight.Click += new System.EventHandler(this.btSmallStraight_Click);
            // 
            // lblLower
            // 
            this.lblLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.Location = new System.Drawing.Point(15, 315);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(82, 13);
            this.lblLower.TabIndex = 12;
            this.lblLower.Text = "Lower scores";
            // 
            // bt4OfAKind
            // 
            this.bt4OfAKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt4OfAKind.Enabled = false;
            this.bt4OfAKind.Location = new System.Drawing.Point(18, 353);
            this.bt4OfAKind.Name = "bt4OfAKind";
            this.bt4OfAKind.Size = new System.Drawing.Size(80, 23);
            this.bt4OfAKind.TabIndex = 11;
            this.bt4OfAKind.Text = "4 of a Kind";
            this.bt4OfAKind.UseVisualStyleBackColor = true;
            this.bt4OfAKind.Click += new System.EventHandler(this.bt4OfAKind_Click);
            // 
            // bt3OfAKind
            // 
            this.bt3OfAKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt3OfAKind.Enabled = false;
            this.bt3OfAKind.Location = new System.Drawing.Point(18, 331);
            this.bt3OfAKind.Name = "bt3OfAKind";
            this.bt3OfAKind.Size = new System.Drawing.Size(80, 23);
            this.bt3OfAKind.TabIndex = 10;
            this.bt3OfAKind.Text = "3 of a Kind";
            this.bt3OfAKind.UseVisualStyleBackColor = true;
            this.bt3OfAKind.Click += new System.EventHandler(this.bt3OfAKind_Click);
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.Location = new System.Drawing.Point(15, 467);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(40, 13);
            this.lblTotalScore.TabIndex = 17;
            this.lblTotalScore.Text = "Total:";
            // 
            // FormYahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(493, 495);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.btYahtzee);
            this.Controls.Add(this.btRoll);
            this.Controls.Add(this.btFullHouse);
            this.Controls.Add(this.btLargeStraight);
            this.Controls.Add(this.btSmallStraight);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.bt4OfAKind);
            this.Controls.Add(this.bt3OfAKind);
            this.Controls.Add(this.btUpper6);
            this.Controls.Add(this.btUpper5);
            this.Controls.Add(this.btUpper4);
            this.Controls.Add(this.btUpper3);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.btUpper2);
            this.Controls.Add(this.btUpper1);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.panelDice);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(509, 534);
            this.Name = "FormYahtzee";
            this.Text = "Yahtzee";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.gbDie5.ResumeLayout(false);
            this.gbDie5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie5)).EndInit();
            this.gbDie4.ResumeLayout(false);
            this.gbDie4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie4)).EndInit();
            this.gbDie3.ResumeLayout(false);
            this.gbDie3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie3)).EndInit();
            this.gbDie2.ResumeLayout(false);
            this.gbDie2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie2)).EndInit();
            this.gbDie1.ResumeLayout(false);
            this.gbDie1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.panelDice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListDice;
        private System.Windows.Forms.CheckBox cbDie1;
        private System.Windows.Forms.GroupBox gbDie5;
        private System.Windows.Forms.PictureBox pbDie5;
        private System.Windows.Forms.CheckBox cbDie5;
        private System.Windows.Forms.GroupBox gbDie4;
        private System.Windows.Forms.PictureBox pbDie4;
        private System.Windows.Forms.CheckBox cbDie4;
        private System.Windows.Forms.GroupBox gbDie3;
        private System.Windows.Forms.PictureBox pbDie3;
        private System.Windows.Forms.CheckBox cbDie3;
        private System.Windows.Forms.GroupBox gbDie2;
        private System.Windows.Forms.PictureBox pbDie2;
        private System.Windows.Forms.CheckBox cbDie2;
        private System.Windows.Forms.GroupBox gbDie1;
        private System.Windows.Forms.PictureBox pbDie1;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.Panel panelDice;
        private System.Windows.Forms.Button btRoll;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.Button btUpper1;
        private System.Windows.Forms.Button btUpper2;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Button btUpper3;
        private System.Windows.Forms.Button btUpper6;
        private System.Windows.Forms.Button btUpper5;
        private System.Windows.Forms.Button btUpper4;
        private System.Windows.Forms.Button btYahtzee;
        private System.Windows.Forms.Button btFullHouse;
        private System.Windows.Forms.Button btLargeStraight;
        private System.Windows.Forms.Button btSmallStraight;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Button bt4OfAKind;
        private System.Windows.Forms.Button bt3OfAKind;
        private System.Windows.Forms.Label lblTotalScore;
    }
}

