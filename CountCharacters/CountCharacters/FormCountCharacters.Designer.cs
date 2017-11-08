namespace CountCharacters
{
    partial class FormCountCharacters
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
            this.btLoad = new System.Windows.Forms.Button();
            this.tbFilenames = new System.Windows.Forms.TextBox();
            this.CharacterFrequencyView = new System.Windows.Forms.DataGridView();
            this.Character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCharacterCountLabel = new System.Windows.Forms.Label();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterFrequencyView)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(12, 13);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "Load File";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // tbFilenames
            // 
            this.tbFilenames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilenames.Enabled = false;
            this.tbFilenames.Location = new System.Drawing.Point(95, 15);
            this.tbFilenames.Name = "tbFilenames";
            this.tbFilenames.ReadOnly = true;
            this.tbFilenames.Size = new System.Drawing.Size(277, 20);
            this.tbFilenames.TabIndex = 2;
            // 
            // CharacterFrequencyView
            // 
            this.CharacterFrequencyView.AllowUserToAddRows = false;
            this.CharacterFrequencyView.AllowUserToDeleteRows = false;
            this.CharacterFrequencyView.AllowUserToResizeRows = false;
            this.CharacterFrequencyView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterFrequencyView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CharacterFrequencyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CharacterFrequencyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Character,
            this.Frequency});
            this.CharacterFrequencyView.Location = new System.Drawing.Point(12, 43);
            this.CharacterFrequencyView.MultiSelect = false;
            this.CharacterFrequencyView.Name = "CharacterFrequencyView";
            this.CharacterFrequencyView.ReadOnly = true;
            this.CharacterFrequencyView.RowHeadersVisible = false;
            this.CharacterFrequencyView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CharacterFrequencyView.Size = new System.Drawing.Size(360, 307);
            this.CharacterFrequencyView.TabIndex = 3;
            // 
            // Character
            // 
            this.Character.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Character.DataPropertyName = "Key";
            this.Character.HeaderText = "Character";
            this.Character.MaxInputLength = 2;
            this.Character.Name = "Character";
            this.Character.ReadOnly = true;
            this.Character.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Character.Width = 78;
            // 
            // Frequency
            // 
            this.Frequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Frequency.DataPropertyName = "Value";
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // lblCharacterCountLabel
            // 
            this.lblCharacterCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCharacterCountLabel.AutoSize = true;
            this.lblCharacterCountLabel.Location = new System.Drawing.Point(9, 353);
            this.lblCharacterCountLabel.Name = "lblCharacterCountLabel";
            this.lblCharacterCountLabel.Size = new System.Drawing.Size(34, 13);
            this.lblCharacterCountLabel.TabIndex = 4;
            this.lblCharacterCountLabel.Text = "Total:";
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Location = new System.Drawing.Point(49, 353);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(0, 13);
            this.lblCharacterCount.TabIndex = 5;
            // 
            // FormCountCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 375);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.lblCharacterCountLabel);
            this.Controls.Add(this.CharacterFrequencyView);
            this.Controls.Add(this.tbFilenames);
            this.Controls.Add(this.btLoad);
            this.Name = "FormCountCharacters";
            this.Text = "Count Character Frequencies";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterFrequencyView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.TextBox tbFilenames;
        private System.Windows.Forms.DataGridView CharacterFrequencyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Character;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.Label lblCharacterCountLabel;
        private System.Windows.Forms.Label lblCharacterCount;
    }
}

