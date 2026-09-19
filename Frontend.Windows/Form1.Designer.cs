namespace Frontend.Windows
{
    partial class ExpressionEvaluator
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
            Button btnPlus;
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            bt9 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnMinus = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnPow = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btnResult = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnPlus = new Button();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.Highlight;
            btnPlus.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnPlus.ForeColor = SystemColors.ControlLightLight;
            btnPlus.Location = new Point(278, 191);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 51);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = SystemColors.ActiveCaption;
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(426, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn1.Location = new Point(12, 191);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 51);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn2.Location = new Point(93, 191);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 51);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn3.Location = new Point(174, 191);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 51);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn4.Location = new Point(12, 138);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 47);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn5.Location = new Point(93, 138);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 47);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn6.Location = new Point(174, 138);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 47);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonHighlight;
            btn7.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn7.Location = new Point(12, 87);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 45);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn8.Location = new Point(93, 87);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 45);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // bt9
            // 
            bt9.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            bt9.Location = new Point(174, 87);
            bt9.Name = "bt9";
            bt9.Size = new Size(75, 45);
            bt9.TabIndex = 9;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnDot.Location = new Point(174, 248);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 51);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btn0.Location = new Point(12, 248);
            btn0.Name = "btn0";
            btn0.Size = new Size(156, 51);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button12_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.Highlight;
            btnMinus.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnMinus.ForeColor = SystemColors.ControlLightLight;
            btnMinus.Location = new Point(278, 248);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(75, 51);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.Highlight;
            btnDivide.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnDivide.ForeColor = SystemColors.ControlLightLight;
            btnDivide.Location = new Point(278, 87);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 45);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.Highlight;
            btnMultiply.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnMultiply.ForeColor = SystemColors.ControlLightLight;
            btnMultiply.Location = new Point(278, 138);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 47);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = SystemColors.Highlight;
            btnPow.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnPow.ForeColor = SystemColors.ControlLightLight;
            btnPow.Location = new Point(368, 87);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(75, 45);
            btnPow.TabIndex = 18;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = SystemColors.Highlight;
            btnOpenParenthesis.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnOpenParenthesis.ForeColor = SystemColors.ControlLightLight;
            btnOpenParenthesis.Location = new Point(368, 138);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(75, 47);
            btnOpenParenthesis.TabIndex = 17;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = SystemColors.Highlight;
            btnCloseParenthesis.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnCloseParenthesis.ForeColor = SystemColors.ControlLightLight;
            btnCloseParenthesis.Location = new Point(368, 191);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(75, 51);
            btnCloseParenthesis.TabIndex = 20;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = SystemColors.Highlight;
            btnResult.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnResult.ForeColor = SystemColors.ControlLightLight;
            btnResult.Location = new Point(368, 248);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(75, 51);
            btnResult.TabIndex = 19;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.HotTrack;
            btnClear.Location = new Point(120, 41);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 40);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.HotTrack;
            btnDelete.Location = new Point(302, 41);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ExpressionEvaluator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(450, 320);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnResult);
            Controls.Add(btnPow);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnPlus);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(bt9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            ForeColor = SystemColors.ControlText;
            Name = "ExpressionEvaluator";
            Text = "ExpressionEvaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button bt9;
        private Button btnDot;
        private Button btn0;
        private Button btnMinus;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnPlus;
        private Button btnPow;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btnResult;
        private Button btnClear;
        private Button btnDelete;
    }
}
