using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculator_2
{
    partial class Form1
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
            btnMultiply = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btnPercentage = new Button();
            btnSquare = new Button();
            btnClear = new Button();
            btnerase = new Button();
            textBox = new TextBox();
            CalBox = new TextBox();
            btnCE = new Button();
            btnFraction = new Button();
            btnConvert = new Button();
            btnRoot = new Button();
            SuspendLayout();
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(223, 248);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(65, 43);
            btnMultiply.TabIndex = 0;
            btnMultiply.TabStop = false;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(83, 395);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 43);
            btn0.TabIndex = 0;
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(154, 395);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(65, 43);
            btnDot.TabIndex = 0;
            btnDot.TabStop = false;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(223, 395);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(65, 43);
            btnEqual.TabIndex = 0;
            btnEqual.TabStop = false;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 346);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 43);
            btn1.TabIndex = 0;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(83, 346);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 43);
            btn2.TabIndex = 0;
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(154, 346);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 43);
            btn3.TabIndex = 0;
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(223, 346);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(65, 43);
            btnPlus.TabIndex = 0;
            btnPlus.TabStop = false;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 297);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 43);
            btn4.TabIndex = 0;
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(83, 297);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 43);
            btn5.TabIndex = 0;
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(153, 297);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 43);
            btn6.TabIndex = 0;
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(223, 297);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(65, 43);
            btnMinus.TabIndex = 0;
            btnMinus.TabStop = false;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 248);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 43);
            btn7.TabIndex = 0;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(83, 248);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 43);
            btn8.TabIndex = 0;
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(153, 248);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 43);
            btn9.TabIndex = 0;
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(223, 199);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(65, 43);
            btnDivide.TabIndex = 0;
            btnDivide.TabStop = false;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnPercentage
            // 
            btnPercentage.Location = new Point(12, 150);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(65, 43);
            btnPercentage.TabIndex = 0;
            btnPercentage.TabStop = false;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(83, 199);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(65, 43);
            btnSquare.TabIndex = 0;
            btnSquare.TabStop = false;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(152, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(65, 43);
            btnClear.TabIndex = 0;
            btnClear.TabStop = false;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnerase
            // 
            btnerase.BackColor = SystemColors.ControlLight;
            btnerase.FlatAppearance.BorderColor = Color.White;
            btnerase.FlatAppearance.BorderSize = 0;
            btnerase.FlatAppearance.MouseDownBackColor = Color.White;
            btnerase.FlatAppearance.MouseOverBackColor = Color.White;
            btnerase.Location = new Point(223, 150);
            btnerase.Name = "btnerase";
            btnerase.Size = new Size(65, 43);
            btnerase.TabIndex = 0;
            btnerase.TabStop = false;
            btnerase.Text = "←";
            btnerase.UseVisualStyleBackColor = false;
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.Menu;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Cursor = Cursors.IBeam;
            textBox.Location = new Point(12, 79);
            textBox.Name = "textBox";
            textBox.Size = new Size(276, 16);
            textBox.TabIndex = 2;
            textBox.TabStop = false;
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CalBox
            // 
            CalBox.BorderStyle = BorderStyle.None;
            CalBox.Cursor = Cursors.IBeam;
            CalBox.Enabled = false;
            CalBox.Location = new Point(12, 50);
            CalBox.Name = "CalBox";
            CalBox.ReadOnly = true;
            CalBox.Size = new Size(276, 16);
            CalBox.TabIndex = 2;
            CalBox.TabStop = false;
            CalBox.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(83, 150);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(65, 43);
            btnCE.TabIndex = 0;
            btnCE.TabStop = false;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnFraction
            // 
            btnFraction.Location = new Point(12, 199);
            btnFraction.Name = "btnFraction";
            btnFraction.Size = new Size(65, 43);
            btnFraction.TabIndex = 0;
            btnFraction.TabStop = false;
            btnFraction.Text = "1/x";
            btnFraction.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(12, 395);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(65, 43);
            btnConvert.TabIndex = 0;
            btnConvert.TabStop = false;
            btnConvert.Text = "+/-";
            btnConvert.UseVisualStyleBackColor = true;
            // 
            // btnRoot
            // 
            btnRoot.Location = new Point(152, 199);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(65, 43);
            btnRoot.TabIndex = 0;
            btnRoot.TabStop = false;
            btnRoot.Text = "√x";
            btnRoot.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450);
            Controls.Add(CalBox);
            Controls.Add(textBox);
            Controls.Add(btnRoot);
            Controls.Add(btnerase);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btnMinus);
            Controls.Add(btnConvert);
            Controls.Add(btn6);
            Controls.Add(btnSquare);
            Controls.Add(btnPlus);
            Controls.Add(btn8);
            Controls.Add(btn3);
            Controls.Add(btnFraction);
            Controls.Add(btn5);
            Controls.Add(btnPercentage);
            Controls.Add(btnEqual);
            Controls.Add(btn7);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btnDot);
            Controls.Add(btn1);
            Controls.Add(btnCE);
            Controls.Add(btn0);
            Controls.Add(btnMultiply);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += TextBox_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMultiply;
        private Button btn0;
        private Button btnDot;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btnPercentage;
        private Button btnSquare;
        private Button btnClear;
        private Button btnerase;
        private TextBox textBox;
        private TextBox CalBox;
        private Button btnCE;
        private Button btnFraction;
        private Button btnConvert;
        private Button btnRoot;
    }
}
