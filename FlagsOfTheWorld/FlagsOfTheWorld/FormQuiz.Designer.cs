namespace FlagsOfTheWorld
{
    partial class FormQuiz
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
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.btFinished = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFlag
            // 
            this.pbFlag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbFlag.Location = new System.Drawing.Point(14, 41);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(400, 300);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFlag.TabIndex = 0;
            this.pbFlag.TabStop = false;
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBack.Location = new System.Drawing.Point(340, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Exit";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tbAnswer.Location = new System.Drawing.Point(14, 384);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(319, 44);
            this.tbAnswer.TabIndex = 3;
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btSubmit.Location = new System.Drawing.Point(340, 384);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 44);
            this.btSubmit.TabIndex = 4;
            this.btSubmit.Text = "OK";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 344);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(286, 37);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Name the country";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuestionNumber.Location = new System.Drawing.Point(12, 15);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(77, 20);
            this.lblQuestionNumber.TabIndex = 6;
            this.lblQuestionNumber.Text = "Question ";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(14, 114);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(400, 71);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.White;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btNext.Location = new System.Drawing.Point(121, 275);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(195, 66);
            this.btNext.TabIndex = 8;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Visible = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lblInfo2
            // 
            this.lblInfo2.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblInfo2.Location = new System.Drawing.Point(14, 195);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(400, 77);
            this.lblInfo2.TabIndex = 9;
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfo2.Visible = false;
            // 
            // btFinished
            // 
            this.btFinished.BackColor = System.Drawing.Color.White;
            this.btFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btFinished.Location = new System.Drawing.Point(121, 275);
            this.btFinished.Name = "btFinished";
            this.btFinished.Size = new System.Drawing.Size(195, 66);
            this.btFinished.TabIndex = 10;
            this.btFinished.Text = "Exit";
            this.btFinished.UseVisualStyleBackColor = false;
            this.btFinished.Visible = false;
            this.btFinished.Click += new System.EventHandler(this.btFinished_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 444);
            this.Controls.Add(this.btFinished);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.pbFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormQuiz";
            this.Text = "Flags of the World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuiz_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Button btFinished;
    }
}