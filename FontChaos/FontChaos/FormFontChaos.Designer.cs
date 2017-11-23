namespace FontChaos
{
    partial class FormFontChaos
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.splitContainerInputOutput = new System.Windows.Forms.SplitContainer();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btChaos = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInputOutput)).BeginInit();
            this.splitContainerInputOutput.Panel1.SuspendLayout();
            this.splitContainerInputOutput.Panel2.SuspendLayout();
            this.splitContainerInputOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(3, 22);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(280, 267);
            this.tbInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(0, 6);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(34, 13);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "Input:";
            // 
            // splitContainerInputOutput
            // 
            this.splitContainerInputOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerInputOutput.IsSplitterFixed = true;
            this.splitContainerInputOutput.Location = new System.Drawing.Point(12, 4);
            this.splitContainerInputOutput.Name = "splitContainerInputOutput";
            // 
            // splitContainerInputOutput.Panel1
            // 
            this.splitContainerInputOutput.Panel1.Controls.Add(this.tbInput);
            this.splitContainerInputOutput.Panel1.Controls.Add(this.lblInput);
            // 
            // splitContainerInputOutput.Panel2
            // 
            this.splitContainerInputOutput.Panel2.Controls.Add(this.tbOutput);
            this.splitContainerInputOutput.Panel2.Controls.Add(this.lblOutput);
            this.splitContainerInputOutput.Size = new System.Drawing.Size(580, 292);
            this.splitContainerInputOutput.SplitterDistance = 290;
            this.splitContainerInputOutput.TabIndex = 10;
            this.splitContainerInputOutput.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(0, 5);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output:";
            // 
            // btChaos
            // 
            this.btChaos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btChaos.Location = new System.Drawing.Point(490, 306);
            this.btChaos.Name = "btChaos";
            this.btChaos.Size = new System.Drawing.Size(102, 23);
            this.btChaos.TabIndex = 4;
            this.btChaos.Text = "Randomize Fonts";
            this.btChaos.UseVisualStyleBackColor = true;
            this.btChaos.Click += new System.EventHandler(this.btChaos_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Location = new System.Drawing.Point(6, 21);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(280, 267);
            this.tbOutput.TabIndex = 2;
            this.tbOutput.Text = "";
            // 
            // FormFontChaos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 341);
            this.Controls.Add(this.btChaos);
            this.Controls.Add(this.splitContainerInputOutput);
            this.MinimumSize = new System.Drawing.Size(620, 380);
            this.Name = "FormFontChaos";
            this.Text = "FontChaos";
            this.splitContainerInputOutput.Panel1.ResumeLayout(false);
            this.splitContainerInputOutput.Panel1.PerformLayout();
            this.splitContainerInputOutput.Panel2.ResumeLayout(false);
            this.splitContainerInputOutput.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInputOutput)).EndInit();
            this.splitContainerInputOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.SplitContainer splitContainerInputOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btChaos;
        private System.Windows.Forms.RichTextBox tbOutput;
    }
}

