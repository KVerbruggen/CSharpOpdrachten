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
            this.gbDies = new System.Windows.Forms.GroupBox();
            this.imageListDies = new System.Windows.Forms.ImageList(this.components);
            this.cbDie1 = new System.Windows.Forms.CheckBox();
            this.menuStripMain.SuspendLayout();
            this.gbDies.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(284, 24);
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
            // gbDies
            // 
            this.gbDies.Controls.Add(this.cbDie1);
            this.gbDies.Location = new System.Drawing.Point(13, 28);
            this.gbDies.Name = "gbDies";
            this.gbDies.Size = new System.Drawing.Size(259, 100);
            this.gbDies.TabIndex = 1;
            this.gbDies.TabStop = false;
            // 
            // imageListDies
            // 
            this.imageListDies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDies.ImageStream")));
            this.imageListDies.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDies.Images.SetKeyName(0, "1.png");
            this.imageListDies.Images.SetKeyName(1, "2.png");
            this.imageListDies.Images.SetKeyName(2, "3.png");
            this.imageListDies.Images.SetKeyName(3, "4.png");
            this.imageListDies.Images.SetKeyName(4, "5.png");
            this.imageListDies.Images.SetKeyName(5, "6.png");
            // 
            // cbDie1
            // 
            this.cbDie1.ImageIndex = 2;
            this.cbDie1.ImageList = this.imageListDies;
            this.cbDie1.Location = new System.Drawing.Point(7, 20);
            this.cbDie1.Name = "cbDie1";
            this.cbDie1.Size = new System.Drawing.Size(111, 50);
            this.cbDie1.TabIndex = 0;
            this.cbDie1.Text = "testing";
            this.cbDie1.UseVisualStyleBackColor = true;
            // 
            // FormYahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbDies);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormYahtzee";
            this.Text = "Yahtzee";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.gbDies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbDies;
        private System.Windows.Forms.CheckBox cbDie1;
        private System.Windows.Forms.ImageList imageListDies;
    }
}

