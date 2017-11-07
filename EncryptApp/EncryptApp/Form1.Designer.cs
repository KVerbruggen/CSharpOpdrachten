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
            this.splitContainerInputOutput = new System.Windows.Forms.SplitContainer();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btLoadKeyFromFile = new System.Windows.Forms.Button();
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
            this.cbEncryptionAlgorithms.Location = new System.Drawing.Point(71, 333);
            this.cbEncryptionAlgorithms.Name = "cbEncryptionAlgorithms";
            this.cbEncryptionAlgorithms.Size = new System.Drawing.Size(224, 21);
            this.cbEncryptionAlgorithms.TabIndex = 3;
            // 
            // btEncryptToFile
            // 
            this.btEncryptToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEncryptToFile.Location = new System.Drawing.Point(396, 302);
            this.btEncryptToFile.Name = "btEncryptToFile";
            this.btEncryptToFile.Size = new System.Drawing.Size(104, 23);
            this.btEncryptToFile.TabIndex = 4;
            this.btEncryptToFile.Text = "Encrypt and Save";
            this.btEncryptToFile.UseVisualStyleBackColor = true;
            // 
            // btDecryptToFile
            // 
            this.btDecryptToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDecryptToFile.Location = new System.Drawing.Point(396, 331);
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
            this.lblCbAlgorithm.Location = new System.Drawing.Point(12, 336);
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
            // splitContainerInputOutput
            // 
            this.splitContainerInputOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.splitContainerInputOutput.Panel2.Controls.Add(this.lblOutput);
            this.splitContainerInputOutput.Panel2.Controls.Add(this.tbOutput);
            this.splitContainerInputOutput.Size = new System.Drawing.Size(580, 292);
            this.splitContainerInputOutput.SplitterDistance = 290;
            this.splitContainerInputOutput.TabIndex = 10;
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
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
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
            // lblKey
            // 
            this.lblKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 307);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(28, 13);
            this.lblKey.TabIndex = 14;
            this.lblKey.Text = "Key:";
            // 
            // tbKey
            // 
            this.tbKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbKey.Location = new System.Drawing.Point(71, 304);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(121, 20);
            this.tbKey.TabIndex = 15;
            // 
            // btLoadKeyFromFile
            // 
            this.btLoadKeyFromFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btLoadKeyFromFile.Location = new System.Drawing.Point(198, 302);
            this.btLoadKeyFromFile.Name = "btLoadKeyFromFile";
            this.btLoadKeyFromFile.Size = new System.Drawing.Size(98, 23);
            this.btLoadKeyFromFile.TabIndex = 16;
            this.btLoadKeyFromFile.Text = "Get Key From File";
            this.btLoadKeyFromFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.btLoadKeyFromFile);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.btEncrypt);
            this.Controls.Add(this.splitContainerInputOutput);
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
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainerInputOutput.Panel1.ResumeLayout(false);
            this.splitContainerInputOutput.Panel1.PerformLayout();
            this.splitContainerInputOutput.Panel2.ResumeLayout(false);
            this.splitContainerInputOutput.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInputOutput)).EndInit();
            this.splitContainerInputOutput.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainerInputOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btLoadKeyFromFile;
    }
}

