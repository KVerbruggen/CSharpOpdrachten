namespace EncryptApp
{
    partial class Form1
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
            this.btEncryptFromFile = new System.Windows.Forms.Button();
            this.cbEncryptionAlgorithms = new System.Windows.Forms.ComboBox();
            this.btEncryptToFile = new System.Windows.Forms.Button();
            this.btDecryptToFile = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblCbAlgorithm = new System.Windows.Forms.Label();
            this.btDecryptFile = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.btDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // btEncryptFromFile
            // 
            this.btEncryptFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEncryptFromFile.Location = new System.Drawing.Point(505, 302);
            this.btEncryptFromFile.Name = "btEncryptFromFile";
            this.btEncryptFromFile.Size = new System.Drawing.Size(84, 23);
            this.btEncryptFromFile.TabIndex = 1;
            this.btEncryptFromFile.Text = "Encrypt File";
            this.btEncryptFromFile.UseVisualStyleBackColor = true;
            // 
            // cbEncryptionAlgorithms
            // 
            this.cbEncryptionAlgorithms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEncryptionAlgorithms.FormattingEnabled = true;
            this.cbEncryptionAlgorithms.Location = new System.Drawing.Point(15, 333);
            this.cbEncryptionAlgorithms.Name = "cbEncryptionAlgorithms";
            this.cbEncryptionAlgorithms.Size = new System.Drawing.Size(287, 21);
            this.cbEncryptionAlgorithms.TabIndex = 3;
            // 
            // btEncryptToFile
            // 
            this.btEncryptToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEncryptToFile.Location = new System.Drawing.Point(395, 302);
            this.btEncryptToFile.Name = "btEncryptToFile";
            this.btEncryptToFile.Size = new System.Drawing.Size(104, 23);
            this.btEncryptToFile.TabIndex = 4;
            this.btEncryptToFile.Text = "Encrypt and Save";
            this.btEncryptToFile.UseVisualStyleBackColor = true;
            // 
            // btDecryptToFile
            // 
            this.btDecryptToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDecryptToFile.Location = new System.Drawing.Point(395, 331);
            this.btDecryptToFile.Name = "btDecryptToFile";
            this.btDecryptToFile.Size = new System.Drawing.Size(104, 23);
            this.btDecryptToFile.TabIndex = 5;
            this.btDecryptToFile.Text = "Decrypt and Save";
            this.btDecryptToFile.UseVisualStyleBackColor = true;
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
            // lblCbAlgorithm
            // 
            this.lblCbAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCbAlgorithm.AutoSize = true;
            this.lblCbAlgorithm.Location = new System.Drawing.Point(12, 317);
            this.lblCbAlgorithm.Name = "lblCbAlgorithm";
            this.lblCbAlgorithm.Size = new System.Drawing.Size(53, 13);
            this.lblCbAlgorithm.TabIndex = 7;
            this.lblCbAlgorithm.Text = "Algorithm:";
            // 
            // btDecryptFile
            // 
            this.btDecryptFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDecryptFile.Location = new System.Drawing.Point(505, 331);
            this.btDecryptFile.Name = "btDecryptFile";
            this.btDecryptFile.Size = new System.Drawing.Size(84, 23);
            this.btDecryptFile.TabIndex = 8;
            this.btDecryptFile.Text = "Decrypt File";
            this.btDecryptFile.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOutput.Location = new System.Drawing.Point(3, 22);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(280, 267);
            this.tbOutput.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbInput);
            this.splitContainer1.Panel1.Controls.Add(this.lblInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblOutput);
            this.splitContainer1.Panel2.Controls.Add(this.tbOutput);
            this.splitContainer1.Size = new System.Drawing.Size(580, 292);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 10;
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
            // btEncrypt
            // 
            this.btEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEncrypt.Location = new System.Drawing.Point(308, 302);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(84, 23);
            this.btEncrypt.TabIndex = 11;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.UseVisualStyleBackColor = true;
            // 
            // btDecrypt
            // 
            this.btDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDecrypt.Location = new System.Drawing.Point(308, 331);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(84, 23);
            this.btDecrypt.TabIndex = 12;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.btEncrypt);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btDecryptFile);
            this.Controls.Add(this.lblCbAlgorithm);
            this.Controls.Add(this.btDecryptToFile);
            this.Controls.Add(this.btEncryptToFile);
            this.Controls.Add(this.cbEncryptionAlgorithms);
            this.Controls.Add(this.btEncryptFromFile);
            this.MinimumSize = new System.Drawing.Size(620, 400);
            this.Name = "Form1";
            this.Text = "EncryptApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btEncryptFromFile;
        private System.Windows.Forms.ComboBox cbEncryptionAlgorithms;
        private System.Windows.Forms.Button btEncryptToFile;
        private System.Windows.Forms.Button btDecryptToFile;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblCbAlgorithm;
        private System.Windows.Forms.Button btDecryptFile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Button btDecrypt;
    }
}

