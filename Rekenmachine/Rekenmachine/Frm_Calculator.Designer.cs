namespace Rekenmachine
{
    partial class Frm_Calculator
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
            this.btClear = new System.Windows.Forms.Button();
            this.btClearEntry = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSubtract = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btBackspace = new System.Windows.Forms.Button();
            this.btOpenBracket = new System.Windows.Forms.Button();
            this.btCloseBracket = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.tbFormula = new System.Windows.Forms.TextBox();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btSquare = new System.Windows.Forms.Button();
            this.btSqrt = new System.Windows.Forms.Button();
            this.btInvolution = new System.Windows.Forms.Button();
            this.btPercent = new System.Windows.Forms.Button();
            this.btEuro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInput.Location = new System.Drawing.Point(12, 38);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(210, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyUp);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(12, 65);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(30, 30);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClearEntry
            // 
            this.btClearEntry.Location = new System.Drawing.Point(48, 65);
            this.btClearEntry.Name = "btClearEntry";
            this.btClearEntry.Size = new System.Drawing.Size(30, 30);
            this.btClearEntry.TabIndex = 2;
            this.btClearEntry.Text = "CE";
            this.btClearEntry.UseVisualStyleBackColor = true;
            this.btClearEntry.Click += new System.EventHandler(this.btClearEntry_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt0.Location = new System.Drawing.Point(48, 210);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(30, 30);
            this.bt0.TabIndex = 3;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt1.Location = new System.Drawing.Point(12, 174);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(30, 30);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt2.Location = new System.Drawing.Point(48, 174);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(30, 30);
            this.bt2.TabIndex = 5;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt3.Location = new System.Drawing.Point(84, 174);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(30, 30);
            this.bt3.TabIndex = 6;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt4.Location = new System.Drawing.Point(12, 137);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(30, 30);
            this.bt4.TabIndex = 7;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt5.Location = new System.Drawing.Point(48, 137);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(30, 30);
            this.bt5.TabIndex = 8;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt6.Location = new System.Drawing.Point(84, 137);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(30, 30);
            this.bt6.TabIndex = 9;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt7.Location = new System.Drawing.Point(12, 101);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(30, 30);
            this.bt7.TabIndex = 10;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt8.Location = new System.Drawing.Point(48, 101);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(30, 30);
            this.bt8.TabIndex = 11;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt9.Location = new System.Drawing.Point(84, 101);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(30, 30);
            this.bt9.TabIndex = 12;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAdd.Location = new System.Drawing.Point(120, 65);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(30, 30);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSubtract
            // 
            this.btSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSubtract.Location = new System.Drawing.Point(120, 101);
            this.btSubtract.Name = "btSubtract";
            this.btSubtract.Size = new System.Drawing.Size(30, 30);
            this.btSubtract.TabIndex = 14;
            this.btSubtract.Text = "-";
            this.btSubtract.UseVisualStyleBackColor = true;
            this.btSubtract.Click += new System.EventHandler(this.btSubtract_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btMultiply.Location = new System.Drawing.Point(120, 137);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(30, 30);
            this.btMultiply.TabIndex = 15;
            this.btMultiply.Text = "×";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btDivide
            // 
            this.btDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDivide.Location = new System.Drawing.Point(120, 174);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(30, 30);
            this.btDivide.TabIndex = 16;
            this.btDivide.Text = "÷";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSubmit.Location = new System.Drawing.Point(192, 65);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(30, 30);
            this.btSubmit.TabIndex = 17;
            this.btSubmit.Text = "=";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btBackspace
            // 
            this.btBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBackspace.Location = new System.Drawing.Point(84, 65);
            this.btBackspace.Name = "btBackspace";
            this.btBackspace.Size = new System.Drawing.Size(30, 30);
            this.btBackspace.TabIndex = 18;
            this.btBackspace.Text = "←";
            this.btBackspace.UseVisualStyleBackColor = true;
            this.btBackspace.Click += new System.EventHandler(this.btBackspace_Click);
            // 
            // btOpenBracket
            // 
            this.btOpenBracket.Enabled = false;
            this.btOpenBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btOpenBracket.Location = new System.Drawing.Point(84, 210);
            this.btOpenBracket.Name = "btOpenBracket";
            this.btOpenBracket.Size = new System.Drawing.Size(30, 30);
            this.btOpenBracket.TabIndex = 19;
            this.btOpenBracket.Text = "(";
            this.btOpenBracket.UseVisualStyleBackColor = true;
            // 
            // btCloseBracket
            // 
            this.btCloseBracket.Enabled = false;
            this.btCloseBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btCloseBracket.Location = new System.Drawing.Point(120, 210);
            this.btCloseBracket.Name = "btCloseBracket";
            this.btCloseBracket.Size = new System.Drawing.Size(30, 30);
            this.btCloseBracket.TabIndex = 20;
            this.btCloseBracket.Text = ")";
            this.btCloseBracket.UseVisualStyleBackColor = true;
            // 
            // btDot
            // 
            this.btDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDot.Location = new System.Drawing.Point(12, 210);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(30, 30);
            this.btDot.TabIndex = 21;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            // 
            // tbFormula
            // 
            this.tbFormula.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbFormula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFormula.Enabled = false;
            this.tbFormula.Location = new System.Drawing.Point(12, 12);
            this.tbFormula.Name = "tbFormula";
            this.tbFormula.ReadOnly = true;
            this.tbFormula.Size = new System.Drawing.Size(210, 20);
            this.tbFormula.TabIndex = 22;
            this.tbFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(229, 12);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(120, 225);
            this.lbHistory.TabIndex = 23;
            // 
            // btSquare
            // 
            this.btSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btSquare.Location = new System.Drawing.Point(155, 175);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(30, 30);
            this.btSquare.TabIndex = 24;
            this.btSquare.Text = "x²";
            this.btSquare.UseVisualStyleBackColor = true;
            this.btSquare.Click += new System.EventHandler(this.btSquare_Click);
            // 
            // btSqrt
            // 
            this.btSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btSqrt.Location = new System.Drawing.Point(155, 211);
            this.btSqrt.Name = "btSqrt";
            this.btSqrt.Size = new System.Drawing.Size(31, 30);
            this.btSqrt.TabIndex = 25;
            this.btSqrt.Text = "√x";
            this.btSqrt.UseVisualStyleBackColor = true;
            this.btSqrt.Click += new System.EventHandler(this.btSqrt_Click);
            // 
            // btInvolution
            // 
            this.btInvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btInvolution.Location = new System.Drawing.Point(155, 137);
            this.btInvolution.Name = "btInvolution";
            this.btInvolution.Size = new System.Drawing.Size(30, 30);
            this.btInvolution.TabIndex = 27;
            this.btInvolution.Text = "xⁿ";
            this.btInvolution.UseVisualStyleBackColor = true;
            this.btInvolution.Click += new System.EventHandler(this.btInvolution_Click);
            // 
            // btPercent
            // 
            this.btPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btPercent.Location = new System.Drawing.Point(155, 65);
            this.btPercent.Name = "btPercent";
            this.btPercent.Size = new System.Drawing.Size(31, 30);
            this.btPercent.TabIndex = 28;
            this.btPercent.Text = "%";
            this.btPercent.UseVisualStyleBackColor = true;
            this.btPercent.Click += new System.EventHandler(this.btPercent_Click);
            // 
            // btEuro
            // 
            this.btEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btEuro.Location = new System.Drawing.Point(155, 101);
            this.btEuro.Name = "btEuro";
            this.btEuro.Size = new System.Drawing.Size(31, 30);
            this.btEuro.TabIndex = 29;
            this.btEuro.Text = "€";
            this.btEuro.UseVisualStyleBackColor = true;
            this.btEuro.Click += new System.EventHandler(this.btEuro_Click);
            // 
            // Frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 251);
            this.Controls.Add(this.btEuro);
            this.Controls.Add(this.btPercent);
            this.Controls.Add(this.btInvolution);
            this.Controls.Add(this.btSqrt);
            this.Controls.Add(this.btSquare);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.tbFormula);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.btCloseBracket);
            this.Controls.Add(this.btOpenBracket);
            this.Controls.Add(this.btBackspace);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btSubtract);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btClearEntry);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Calculator";
            this.Text = "Rekenmachine";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_Calculator_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btClearEntry;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSubtract;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btBackspace;
        private System.Windows.Forms.Button btOpenBracket;
        private System.Windows.Forms.Button btCloseBracket;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.TextBox tbFormula;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btSquare;
        private System.Windows.Forms.Button btSqrt;
        private System.Windows.Forms.Button btInvolution;
        private System.Windows.Forms.Button btPercent;
        private System.Windows.Forms.Button btEuro;
    }
}

