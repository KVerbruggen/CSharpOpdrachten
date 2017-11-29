namespace Rekenmachine2
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
            this.btSubmit = new System.Windows.Forms.Button();
            this.btBackspace = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.tbFormula = new System.Windows.Forms.TextBox();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btPercent = new System.Windows.Forms.Button();
            this.btEuro = new System.Windows.Forms.Button();
            this.btInverse = new Rekenmachine2.ButtonCombiningOperator();
            this.btInvolution = new Rekenmachine2.ButtonOperator();
            this.btSqrt = new Rekenmachine2.ButtonCombiningOperator();
            this.btSquare = new Rekenmachine2.ButtonCombiningOperator();
            this.btDivide = new Rekenmachine2.ButtonOperator();
            this.btMultiply = new Rekenmachine2.ButtonOperator();
            this.btSubtract = new Rekenmachine2.ButtonOperator();
            this.btAdd = new Rekenmachine2.ButtonOperator();
            this.bt9 = new Rekenmachine2.ButtonNumber();
            this.bt8 = new Rekenmachine2.ButtonNumber();
            this.bt7 = new Rekenmachine2.ButtonNumber();
            this.bt6 = new Rekenmachine2.ButtonNumber();
            this.bt5 = new Rekenmachine2.ButtonNumber();
            this.bt4 = new Rekenmachine2.ButtonNumber();
            this.bt3 = new Rekenmachine2.ButtonNumber();
            this.bt2 = new Rekenmachine2.ButtonNumber();
            this.bt1 = new Rekenmachine2.ButtonNumber();
            this.bt0 = new Rekenmachine2.ButtonNumber();
            this.btRooting = new Rekenmachine2.ButtonOperator();
            this.btFactorial = new Rekenmachine2.ButtonOperator();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInput.Location = new System.Drawing.Point(12, 38);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(177, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyUp);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(12, 65);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(31, 30);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btClearEntry
            // 
            this.btClearEntry.Location = new System.Drawing.Point(48, 65);
            this.btClearEntry.Name = "btClearEntry";
            this.btClearEntry.Size = new System.Drawing.Size(31, 30);
            this.btClearEntry.TabIndex = 2;
            this.btClearEntry.Text = "CE";
            this.btClearEntry.UseVisualStyleBackColor = true;
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSubmit.Location = new System.Drawing.Point(158, 65);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(31, 30);
            this.btSubmit.TabIndex = 17;
            this.btSubmit.Text = "=";
            this.btSubmit.UseVisualStyleBackColor = true;
            // 
            // btBackspace
            // 
            this.btBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBackspace.Location = new System.Drawing.Point(84, 65);
            this.btBackspace.Name = "btBackspace";
            this.btBackspace.Size = new System.Drawing.Size(31, 30);
            this.btBackspace.TabIndex = 18;
            this.btBackspace.Text = "←";
            this.btBackspace.UseVisualStyleBackColor = true;
            // 
            // btDot
            // 
            this.btDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDot.Location = new System.Drawing.Point(12, 210);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(31, 30);
            this.btDot.TabIndex = 21;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.btDot_Click);
            // 
            // tbFormula
            // 
            this.tbFormula.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbFormula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFormula.Enabled = false;
            this.tbFormula.Location = new System.Drawing.Point(12, 12);
            this.tbFormula.Name = "tbFormula";
            this.tbFormula.ReadOnly = true;
            this.tbFormula.Size = new System.Drawing.Size(177, 20);
            this.tbFormula.TabIndex = 22;
            this.tbFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.IntegralHeight = false;
            this.lbHistory.Location = new System.Drawing.Point(195, 12);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(120, 228);
            this.lbHistory.TabIndex = 23;
            // 
            // btPercent
            // 
            this.btPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btPercent.Location = new System.Drawing.Point(48, 246);
            this.btPercent.Name = "btPercent";
            this.btPercent.Size = new System.Drawing.Size(31, 30);
            this.btPercent.TabIndex = 28;
            this.btPercent.Text = "%";
            this.btPercent.UseVisualStyleBackColor = true;
            // 
            // btEuro
            // 
            this.btEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btEuro.Location = new System.Drawing.Point(12, 246);
            this.btEuro.Name = "btEuro";
            this.btEuro.Size = new System.Drawing.Size(31, 30);
            this.btEuro.TabIndex = 29;
            this.btEuro.Text = "€";
            this.btEuro.UseVisualStyleBackColor = true;
            // 
            // btInverse
            // 
            this.btInverse.BackColor = System.Drawing.Color.Transparent;
            this.btInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btInverse.InputFirst = true;
            this.btInverse.Location = new System.Drawing.Point(120, 210);
            this.btInverse.Name = "btInverse";
            this.btInverse.Number = 1;
            this.btInverse.Operator = Rekenmachine2.Operator.Division;
            this.btInverse.Size = new System.Drawing.Size(31, 30);
            this.btInverse.TabIndex = 30;
            this.btInverse.Text = "1/x";
            this.btInverse.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btInvolution
            // 
            this.btInvolution.BackColor = System.Drawing.Color.Transparent;
            this.btInvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btInvolution.Location = new System.Drawing.Point(158, 101);
            this.btInvolution.Name = "btInvolution";
            this.btInvolution.Operator = Rekenmachine2.Operator.Involution;
            this.btInvolution.Size = new System.Drawing.Size(31, 30);
            this.btInvolution.TabIndex = 27;
            this.btInvolution.Text = "xⁿ";
            this.btInvolution.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btSqrt
            // 
            this.btSqrt.BackColor = System.Drawing.Color.Transparent;
            this.btSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btSqrt.InputFirst = false;
            this.btSqrt.Location = new System.Drawing.Point(158, 174);
            this.btSqrt.Name = "btSqrt";
            this.btSqrt.Number = 2;
            this.btSqrt.Operator = Rekenmachine2.Operator.Rooting;
            this.btSqrt.Size = new System.Drawing.Size(31, 30);
            this.btSqrt.TabIndex = 25;
            this.btSqrt.Text = "√x";
            this.btSqrt.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btSquare
            // 
            this.btSquare.BackColor = System.Drawing.Color.Transparent;
            this.btSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btSquare.InputFirst = true;
            this.btSquare.Location = new System.Drawing.Point(158, 137);
            this.btSquare.Name = "btSquare";
            this.btSquare.Number = 2;
            this.btSquare.Operator = Rekenmachine2.Operator.Involution;
            this.btSquare.Size = new System.Drawing.Size(31, 30);
            this.btSquare.TabIndex = 24;
            this.btSquare.Text = "x²";
            this.btSquare.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btDivide
            // 
            this.btDivide.BackColor = System.Drawing.Color.Transparent;
            this.btDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDivide.Location = new System.Drawing.Point(120, 174);
            this.btDivide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDivide.Name = "btDivide";
            this.btDivide.Operator = Rekenmachine2.Operator.Division;
            this.btDivide.Size = new System.Drawing.Size(31, 30);
            this.btDivide.TabIndex = 16;
            this.btDivide.Text = "÷";
            this.btDivide.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.BackColor = System.Drawing.Color.Transparent;
            this.btMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btMultiply.Location = new System.Drawing.Point(120, 137);
            this.btMultiply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Operator = Rekenmachine2.Operator.Multiplication;
            this.btMultiply.Size = new System.Drawing.Size(31, 30);
            this.btMultiply.TabIndex = 15;
            this.btMultiply.Text = "×";
            this.btMultiply.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btSubtract
            // 
            this.btSubtract.BackColor = System.Drawing.Color.Transparent;
            this.btSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSubtract.Location = new System.Drawing.Point(120, 101);
            this.btSubtract.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSubtract.Name = "btSubtract";
            this.btSubtract.Operator = Rekenmachine2.Operator.Subtraction;
            this.btSubtract.Size = new System.Drawing.Size(31, 30);
            this.btSubtract.TabIndex = 14;
            this.btSubtract.Text = "-";
            this.btSubtract.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAdd.Location = new System.Drawing.Point(120, 65);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Operator = Rekenmachine2.Operator.Addition;
            this.btAdd.Size = new System.Drawing.Size(31, 30);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "+";
            this.btAdd.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.Transparent;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt9.Location = new System.Drawing.Point(84, 101);
            this.bt9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt9.Name = "bt9";
            this.bt9.Number = 0;
            this.bt9.Size = new System.Drawing.Size(31, 30);
            this.bt9.TabIndex = 12;
            this.bt9.Text = "9";
            this.bt9.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.Transparent;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt8.Location = new System.Drawing.Point(48, 101);
            this.bt8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt8.Name = "bt8";
            this.bt8.Number = 0;
            this.bt8.Size = new System.Drawing.Size(31, 30);
            this.bt8.TabIndex = 11;
            this.bt8.Text = "8";
            this.bt8.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.Transparent;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt7.Location = new System.Drawing.Point(12, 101);
            this.bt7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt7.Name = "bt7";
            this.bt7.Number = 0;
            this.bt7.Size = new System.Drawing.Size(31, 30);
            this.bt7.TabIndex = 10;
            this.bt7.Text = "7";
            this.bt7.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.Transparent;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt6.Location = new System.Drawing.Point(84, 137);
            this.bt6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt6.Name = "bt6";
            this.bt6.Number = 0;
            this.bt6.Size = new System.Drawing.Size(31, 30);
            this.bt6.TabIndex = 9;
            this.bt6.Text = "6";
            this.bt6.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Transparent;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt5.Location = new System.Drawing.Point(48, 137);
            this.bt5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt5.Name = "bt5";
            this.bt5.Number = 0;
            this.bt5.Size = new System.Drawing.Size(31, 30);
            this.bt5.TabIndex = 8;
            this.bt5.Text = "5";
            this.bt5.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.Transparent;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt4.Location = new System.Drawing.Point(12, 137);
            this.bt4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt4.Name = "bt4";
            this.bt4.Number = 0;
            this.bt4.Size = new System.Drawing.Size(31, 30);
            this.bt4.TabIndex = 7;
            this.bt4.Text = "4";
            this.bt4.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Transparent;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt3.Location = new System.Drawing.Point(84, 174);
            this.bt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt3.Name = "bt3";
            this.bt3.Number = 0;
            this.bt3.Size = new System.Drawing.Size(31, 30);
            this.bt3.TabIndex = 6;
            this.bt3.Text = "3";
            this.bt3.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Transparent;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt2.Location = new System.Drawing.Point(48, 174);
            this.bt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt2.Name = "bt2";
            this.bt2.Number = 0;
            this.bt2.Size = new System.Drawing.Size(31, 30);
            this.bt2.TabIndex = 5;
            this.bt2.Text = "2";
            this.bt2.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Transparent;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt1.Location = new System.Drawing.Point(12, 174);
            this.bt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt1.Name = "bt1";
            this.bt1.Number = 0;
            this.bt1.Size = new System.Drawing.Size(31, 30);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "1";
            this.bt1.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.Transparent;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt0.Location = new System.Drawing.Point(48, 210);
            this.bt0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt0.Name = "bt0";
            this.bt0.Number = 0;
            this.bt0.Size = new System.Drawing.Size(31, 30);
            this.bt0.TabIndex = 3;
            this.bt0.Text = "0";
            this.bt0.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // btRooting
            // 
            this.btRooting.BackColor = System.Drawing.Color.Transparent;
            this.btRooting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btRooting.Location = new System.Drawing.Point(158, 210);
            this.btRooting.Name = "btRooting";
            this.btRooting.Operator = Rekenmachine2.Operator.Rooting;
            this.btRooting.Size = new System.Drawing.Size(31, 30);
            this.btRooting.TabIndex = 31;
            this.btRooting.Text = "y√x";
            // 
            // btFactorial
            // 
            this.btFactorial.BackColor = System.Drawing.Color.Transparent;
            this.btFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btFactorial.Location = new System.Drawing.Point(84, 210);
            this.btFactorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFactorial.Name = "btFactorial";
            this.btFactorial.Operator = Rekenmachine2.Operator.Factorial;
            this.btFactorial.Size = new System.Drawing.Size(31, 30);
            this.btFactorial.TabIndex = 32;
            this.btFactorial.Text = "!";
            // 
            // Frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 288);
            this.Controls.Add(this.btFactorial);
            this.Controls.Add(this.btRooting);
            this.Controls.Add(this.btInverse);
            this.Controls.Add(this.btEuro);
            this.Controls.Add(this.btPercent);
            this.Controls.Add(this.btInvolution);
            this.Controls.Add(this.btSqrt);
            this.Controls.Add(this.btSquare);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.tbFormula);
            this.Controls.Add(this.btDot);
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
        private Rekenmachine2.ButtonNumber bt0;
        private Rekenmachine2.ButtonNumber bt1;
        private Rekenmachine2.ButtonNumber bt2;
        private Rekenmachine2.ButtonNumber bt3;
        private Rekenmachine2.ButtonNumber bt4;
        private Rekenmachine2.ButtonNumber bt5;
        private Rekenmachine2.ButtonNumber bt6;
        private Rekenmachine2.ButtonNumber bt7;
        private Rekenmachine2.ButtonNumber bt8;
        private Rekenmachine2.ButtonNumber bt9;
        private Rekenmachine2.ButtonOperator btAdd;
        private Rekenmachine2.ButtonOperator btSubtract;
        private Rekenmachine2.ButtonOperator btMultiply;
        private Rekenmachine2.ButtonOperator btDivide;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btBackspace;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.TextBox tbFormula;
        private System.Windows.Forms.ListBox lbHistory;
        private Rekenmachine2.ButtonCombiningOperator btSquare;
        private Rekenmachine2.ButtonCombiningOperator btSqrt;
        private Rekenmachine2.ButtonOperator btInvolution;
        private System.Windows.Forms.Button btPercent;
        private System.Windows.Forms.Button btEuro;
        private ButtonCombiningOperator btInverse;
        private ButtonOperator btRooting;
        private ButtonOperator btFactorial;
    }
}

