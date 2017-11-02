namespace FlagsOfTheWorld
{
    partial class FormMenu
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
            this.btOpenOverview = new System.Windows.Forms.Button();
            this.btStartTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpenOverview
            // 
            this.btOpenOverview.Location = new System.Drawing.Point(82, 48);
            this.btOpenOverview.Name = "btOpenOverview";
            this.btOpenOverview.Size = new System.Drawing.Size(120, 40);
            this.btOpenOverview.TabIndex = 0;
            this.btOpenOverview.Text = "Bekijk vlaggen";
            this.btOpenOverview.UseVisualStyleBackColor = true;
            this.btOpenOverview.Click += new System.EventHandler(this.btOpenOverview_Click);
            // 
            // btStartTest
            // 
            this.btStartTest.Location = new System.Drawing.Point(82, 94);
            this.btStartTest.Name = "btStartTest";
            this.btStartTest.Size = new System.Drawing.Size(120, 40);
            this.btStartTest.TabIndex = 1;
            this.btStartTest.Text = "Oefenen";
            this.btStartTest.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.btStartTest);
            this.Controls.Add(this.btOpenOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenu";
            this.Text = "Flags of the World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenOverview;
        private System.Windows.Forms.Button btStartTest;
    }
}

