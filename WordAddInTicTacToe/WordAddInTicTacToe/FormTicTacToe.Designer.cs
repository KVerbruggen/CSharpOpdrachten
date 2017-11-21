namespace WordAddInTicTacToe
{
    partial class FormTicTacToe
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
            this.tableLayoutPanelTicTacToe = new System.Windows.Forms.TableLayoutPanel();
            this.btTicTacToe1 = new WordAddInTicTacToe.BtTicTacToe();
            this.btTicTacToe2 = new WordAddInTicTacToe.BtTicTacToe();
            this.btTicTacToe3 = new WordAddInTicTacToe.BtTicTacToe();
            this.btTicTacToe4 = new WordAddInTicTacToe.BtTicTacToe();
            this.btTicTacToe5 = new WordAddInTicTacToe.BtTicTacToe();
            this.btTicTacToe6 = new WordAddInTicTacToe.BtTicTacToe();
            this.btTicTacToe7 = new WordAddInTicTacToe.BtTicTacToe();
            this.btTicTacToe8 = new WordAddInTicTacToe.BtTicTacToe();
            this.btTicTacToe9 = new WordAddInTicTacToe.BtTicTacToe();
            this.btRestart = new System.Windows.Forms.Button();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pbCurrentPlayer = new System.Windows.Forms.PictureBox();
            this.pbLine = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelTicTacToe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTicTacToe
            // 
            this.tableLayoutPanelTicTacToe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTicTacToe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanelTicTacToe.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelTicTacToe.ColumnCount = 3;
            this.tableLayoutPanelTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe1);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe2);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe3);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe4);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe5);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe6);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe7);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe8);
            this.tableLayoutPanelTicTacToe.Controls.Add(this.btTicTacToe9);
            this.tableLayoutPanelTicTacToe.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanelTicTacToe.Name = "tableLayoutPanelTicTacToe";
            this.tableLayoutPanelTicTacToe.RowCount = 3;
            this.tableLayoutPanelTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelTicTacToe.Size = new System.Drawing.Size(260, 260);
            this.tableLayoutPanelTicTacToe.TabIndex = 0;
            // 
            // btTicTacToe1
            // 
            this.btTicTacToe1.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe1.Location = new System.Drawing.Point(3, 3);
            this.btTicTacToe1.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe1.Name = "btTicTacToe1";
            this.btTicTacToe1.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe1.TabIndex = 0;
            this.btTicTacToe1.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btTicTacToe2
            // 
            this.btTicTacToe2.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe2.Location = new System.Drawing.Point(88, 3);
            this.btTicTacToe2.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe2.Name = "btTicTacToe2";
            this.btTicTacToe2.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe2.TabIndex = 1;
            this.btTicTacToe2.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btTicTacToe3
            // 
            this.btTicTacToe3.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe3.Location = new System.Drawing.Point(173, 3);
            this.btTicTacToe3.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe3.Name = "btTicTacToe3";
            this.btTicTacToe3.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe3.TabIndex = 2;
            this.btTicTacToe3.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btTicTacToe4
            // 
            this.btTicTacToe4.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe4.Location = new System.Drawing.Point(3, 88);
            this.btTicTacToe4.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe4.Name = "btTicTacToe4";
            this.btTicTacToe4.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe4.TabIndex = 3;
            this.btTicTacToe4.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btTicTacToe5
            // 
            this.btTicTacToe5.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe5.Location = new System.Drawing.Point(88, 88);
            this.btTicTacToe5.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe5.Name = "btTicTacToe5";
            this.btTicTacToe5.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe5.TabIndex = 4;
            this.btTicTacToe5.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btTicTacToe6
            // 
            this.btTicTacToe6.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe6.Location = new System.Drawing.Point(173, 88);
            this.btTicTacToe6.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe6.Name = "btTicTacToe6";
            this.btTicTacToe6.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe6.TabIndex = 5;
            this.btTicTacToe6.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btTicTacToe7
            // 
            this.btTicTacToe7.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe7.Location = new System.Drawing.Point(3, 173);
            this.btTicTacToe7.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe7.Name = "btTicTacToe7";
            this.btTicTacToe7.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe7.TabIndex = 6;
            this.btTicTacToe7.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btTicTacToe8
            // 
            this.btTicTacToe8.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe8.Location = new System.Drawing.Point(88, 173);
            this.btTicTacToe8.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe8.Name = "btTicTacToe8";
            this.btTicTacToe8.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe8.TabIndex = 7;
            this.btTicTacToe8.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btTicTacToe9
            // 
            this.btTicTacToe9.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToe9.Location = new System.Drawing.Point(173, 173);
            this.btTicTacToe9.Margin = new System.Windows.Forms.Padding(0);
            this.btTicTacToe9.Name = "btTicTacToe9";
            this.btTicTacToe9.Size = new System.Drawing.Size(82, 82);
            this.btTicTacToe9.TabIndex = 8;
            this.btTicTacToe9.Click += new System.EventHandler(this.btCell_Click);
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(12, 12);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(75, 23);
            this.btRestart.TabIndex = 0;
            this.btRestart.Text = "Restart";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(165, 17);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(76, 13);
            this.lblCurrentPlayer.TabIndex = 1;
            this.lblCurrentPlayer.Text = "Current Player:";
            this.lblCurrentPlayer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(82, 82);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbCurrentPlayer
            // 
            this.pbCurrentPlayer.Location = new System.Drawing.Point(244, 12);
            this.pbCurrentPlayer.Name = "pbCurrentPlayer";
            this.pbCurrentPlayer.Size = new System.Drawing.Size(23, 23);
            this.pbCurrentPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurrentPlayer.TabIndex = 2;
            this.pbCurrentPlayer.TabStop = false;
            // 
            // pbLine
            // 
            this.pbLine.BackColor = System.Drawing.Color.Transparent;
            this.pbLine.BackgroundImage = global::WordAddInTicTacToe.Properties.Resources.Tic_tac_toe_line;
            this.pbLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLine.Location = new System.Drawing.Point(12, 76);
            this.pbLine.Name = "pbLine";
            this.pbLine.Size = new System.Drawing.Size(260, 20);
            this.pbLine.TabIndex = 3;
            this.pbLine.TabStop = false;
            this.pbLine.Visible = false;
            // 
            // FormTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.pbLine);
            this.Controls.Add(this.pbCurrentPlayer);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.tableLayoutPanelTicTacToe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTicTacToe";
            this.Text = "Tic Tac Toe";
            this.tableLayoutPanelTicTacToe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTicTacToe;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private BtTicTacToe btTicTacToe9;
        private BtTicTacToe btTicTacToe8;
        private BtTicTacToe btTicTacToe7;
        private BtTicTacToe btTicTacToe6;
        private BtTicTacToe btTicTacToe5;
        private BtTicTacToe btTicTacToe4;
        private BtTicTacToe btTicTacToe3;
        private BtTicTacToe btTicTacToe2;
        private BtTicTacToe btTicTacToe1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pbCurrentPlayer;
        private System.Windows.Forms.PictureBox pbLine;
    }
}