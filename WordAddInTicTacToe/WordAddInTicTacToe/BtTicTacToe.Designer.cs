﻿namespace WordAddInTicTacToe
{
    partial class BtTicTacToe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btTicTacToeCell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTicTacToeCell
            // 
            this.btTicTacToeCell.BackColor = System.Drawing.Color.Transparent;
            this.btTicTacToeCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTicTacToeCell.Location = new System.Drawing.Point(0, 0);
            this.btTicTacToeCell.Name = "btTicTacToeCell";
            this.btTicTacToeCell.Size = new System.Drawing.Size(150, 150);
            this.btTicTacToeCell.TabIndex = 0;
            this.btTicTacToeCell.UseVisualStyleBackColor = false;
            this.btTicTacToeCell.Click += new System.EventHandler(this.btTicTacToeCell_Click);
            // 
            // BtTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btTicTacToeCell);
            this.Name = "BtTicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTicTacToeCell;
    }
}
