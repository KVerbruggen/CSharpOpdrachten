namespace FlagsOfTheWorld
{
    partial class FormOverview
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
            this.btBack = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBack.Location = new System.Drawing.Point(261, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Terug";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeader.Location = new System.Drawing.Point(10, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(104, 26);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Overzicht";
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMain.AutoSize = true;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(15, 41);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(337, 391);
            this.flowLayoutPanelMain.TabIndex = 4;
            // 
            // FormOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 444);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btBack);
            this.Name = "FormOverview";
            this.Text = "Flags of the World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOverview_FormClosing);
            this.Load += new System.EventHandler(this.FormOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
    }
}