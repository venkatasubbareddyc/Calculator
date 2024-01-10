namespace Calculator_WinApp
{
    partial class CalculatorApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            Btn7 = new Button();
            button5 = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            BtnMultiply = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            BtnEqual = new Button();
            BtnAdd = new Button();
            BtnSubtraction = new Button();
            BtnDot = new Button();
            BtndoubleZero = new Button();
            BtnZero = new Button();
            BtnDivide = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.InactiveCaption;
            txtDisplay.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(66, 21);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.RightToLeft = RightToLeft.Yes;
            txtDisplay.Size = new Size(282, 47);
            txtDisplay.TabIndex = 0;
            // 
            // Btn7
            // 
            Btn7.BackColor = SystemColors.ButtonHighlight;
            Btn7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn7.Location = new Point(66, 94);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(55, 35);
            Btn7.TabIndex = 1;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += Btn7_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(293, 94);
            button5.Name = "button5";
            button5.Size = new Size(55, 35);
            button5.TabIndex = 5;
            button5.Text = "\\";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Btn9
            // 
            Btn9.BackColor = SystemColors.ButtonHighlight;
            Btn9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn9.Location = new Point(212, 94);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(55, 35);
            Btn9.TabIndex = 6;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += Btn9_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = SystemColors.ButtonHighlight;
            Btn8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn8.Location = new Point(141, 94);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(55, 35);
            Btn8.TabIndex = 7;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += Btn8_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = SystemColors.ButtonHighlight;
            Btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn1.Location = new Point(212, 208);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(55, 35);
            Btn1.TabIndex = 8;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = SystemColors.ButtonHighlight;
            Btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn2.Location = new Point(141, 208);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(55, 35);
            Btn2.TabIndex = 9;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = SystemColors.ButtonHighlight;
            Btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn3.Location = new Point(66, 208);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(55, 35);
            Btn3.TabIndex = 10;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += Btn3_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = SystemColors.ButtonHighlight;
            BtnMultiply.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnMultiply.Location = new Point(293, 154);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(55, 35);
            BtnMultiply.TabIndex = 11;
            BtnMultiply.Text = "*";
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += BtnMultiply_Click;
            // 
            // Btn4
            // 
            Btn4.BackColor = SystemColors.ButtonHighlight;
            Btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn4.Location = new Point(212, 154);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(55, 35);
            Btn4.TabIndex = 12;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += Btn4_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = SystemColors.ButtonHighlight;
            Btn5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn5.Location = new Point(141, 154);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(55, 35);
            Btn5.TabIndex = 13;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += Btn5_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = SystemColors.ButtonHighlight;
            Btn6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn6.Location = new Point(66, 154);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(55, 35);
            Btn6.TabIndex = 14;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += Btn6_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = SystemColors.ButtonHighlight;
            BtnEqual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnEqual.Location = new Point(66, 321);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(201, 35);
            BtnEqual.TabIndex = 16;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.ButtonHighlight;
            BtnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnAdd.Location = new Point(293, 321);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(55, 35);
            BtnAdd.TabIndex = 17;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnSubtraction
            // 
            BtnSubtraction.BackColor = SystemColors.ButtonHighlight;
            BtnSubtraction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSubtraction.Location = new Point(293, 270);
            BtnSubtraction.Name = "BtnSubtraction";
            BtnSubtraction.Size = new Size(55, 35);
            BtnSubtraction.TabIndex = 18;
            BtnSubtraction.Text = "-";
            BtnSubtraction.UseVisualStyleBackColor = false;
            BtnSubtraction.Click += BtnSubtraction_Click;
            // 
            // BtnDot
            // 
            BtnDot.BackColor = SystemColors.ButtonHighlight;
            BtnDot.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnDot.Location = new Point(212, 273);
            BtnDot.Name = "BtnDot";
            BtnDot.Size = new Size(55, 35);
            BtnDot.TabIndex = 19;
            BtnDot.Text = ".";
            BtnDot.UseVisualStyleBackColor = false;
            BtnDot.Click += BtnDot_Click;
            // 
            // BtndoubleZero
            // 
            BtndoubleZero.BackColor = SystemColors.ButtonHighlight;
            BtndoubleZero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtndoubleZero.Location = new Point(141, 270);
            BtndoubleZero.Name = "BtndoubleZero";
            BtndoubleZero.Size = new Size(55, 35);
            BtndoubleZero.TabIndex = 20;
            BtndoubleZero.Text = "00";
            BtndoubleZero.UseVisualStyleBackColor = false;
            BtndoubleZero.Click += BtndoubleZero_Click;
            // 
            // BtnZero
            // 
            BtnZero.BackColor = SystemColors.ButtonHighlight;
            BtnZero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnZero.Location = new Point(66, 270);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(55, 35);
            BtnZero.TabIndex = 21;
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = false;
            BtnZero.Click += BtnZero_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.BackColor = SystemColors.ButtonHighlight;
            BtnDivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnDivide.Location = new Point(293, 208);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(55, 35);
            BtnDivide.TabIndex = 22;
            BtnDivide.Text = "/";
            BtnDivide.UseVisualStyleBackColor = false;
            BtnDivide.Click += BtnDivide_Click;
            // 
            // CalculatorApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 392);
            Controls.Add(BtnDivide);
            Controls.Add(BtnZero);
            Controls.Add(BtndoubleZero);
            Controls.Add(BtnDot);
            Controls.Add(BtnSubtraction);
            Controls.Add(BtnAdd);
            Controls.Add(BtnEqual);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(BtnMultiply);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(Btn8);
            Controls.Add(Btn9);
            Controls.Add(button5);
            Controls.Add(Btn7);
            Controls.Add(txtDisplay);
            Name = "CalculatorApp";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button Btn7;
        private Button button5;
        private Button Btn9;
        private Button Btn8;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button BtnMultiply;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button BtnEqual;
        private Button BtnAdd;
        private Button BtnSubtraction;
        private Button BtnDot;
        private Button BtndoubleZero;
        private Button BtnZero;
        private Button BtnDivide;
    }
}
