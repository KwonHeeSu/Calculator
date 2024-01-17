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
            btnmulti = new Button();
            btn0 = new Button();
            btndot = new Button();
            btnequal = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnplus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnminus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btndivide = new Button();
            btnPer = new Button();
            btnn = new Button();
            btnclear = new Button();
            btnerase = new Button();
            textBox = new TextBox();
            CalBox = new TextBox();
            btnce = new Button();
            btnfrac = new Button();
            btnconvert = new Button();
            btnroot = new Button();
            SuspendLayout();
            // 
            // btnmulti
            // 
            btnmulti.Location = new Point(223, 248);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(65, 43);
            btnmulti.TabIndex = 0;
            btnmulti.TabStop = false;
            btnmulti.Text = "×";
            btnmulti.UseVisualStyleBackColor = true;
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
            // btndot
            // 
            btndot.Location = new Point(154, 395);
            btndot.Name = "btndot";
            btndot.Size = new Size(65, 43);
            btndot.TabIndex = 0;
            btndot.TabStop = false;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            // 
            // btnequal
            // 
            btnequal.Location = new Point(223, 395);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(65, 43);
            btnequal.TabIndex = 0;
            btnequal.TabStop = false;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
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
            // btnplus
            // 
            btnplus.Location = new Point(223, 346);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(65, 43);
            btnplus.TabIndex = 0;
            btnplus.TabStop = false;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
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
            // btnminus
            // 
            btnminus.Location = new Point(223, 297);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(65, 43);
            btnminus.TabIndex = 0;
            btnminus.TabStop = false;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
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
            // btndivide
            // 
            btndivide.Location = new Point(223, 199);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(65, 43);
            btndivide.TabIndex = 0;
            btndivide.TabStop = false;
            btndivide.Text = "÷";
            btndivide.UseVisualStyleBackColor = true;
            // 
            // btnPer
            // 
            btnPer.Location = new Point(12, 150);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(65, 43);
            btnPer.TabIndex = 0;
            btnPer.TabStop = false;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = true;
            // 
            // btnn
            // 
            btnn.Location = new Point(83, 199);
            btnn.Name = "btnn";
            btnn.Size = new Size(65, 43);
            btnn.TabIndex = 0;
            btnn.TabStop = false;
            btnn.Text = "x^2";
            btnn.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(152, 150);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(65, 43);
            btnclear.TabIndex = 0;
            btnclear.TabStop = false;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = true;
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
            // btnce
            // 
            btnce.Location = new Point(83, 150);
            btnce.Name = "btnce";
            btnce.Size = new Size(65, 43);
            btnce.TabIndex = 0;
            btnce.TabStop = false;
            btnce.Text = "CE";
            btnce.UseVisualStyleBackColor = true;
            // 
            // btnfrac
            // 
            btnfrac.Location = new Point(12, 199);
            btnfrac.Name = "btnfrac";
            btnfrac.Size = new Size(65, 43);
            btnfrac.TabIndex = 0;
            btnfrac.TabStop = false;
            btnfrac.Text = "1/x";
            btnfrac.UseVisualStyleBackColor = true;
            // 
            // btnconvert
            // 
            btnconvert.Location = new Point(12, 395);
            btnconvert.Name = "btnconvert";
            btnconvert.Size = new Size(65, 43);
            btnconvert.TabIndex = 0;
            btnconvert.TabStop = false;
            btnconvert.Text = "+/-";
            btnconvert.UseVisualStyleBackColor = true;
            // 
            // btnroot
            // 
            btnroot.Location = new Point(152, 199);
            btnroot.Name = "btnroot";
            btnroot.Size = new Size(65, 43);
            btnroot.TabIndex = 0;
            btnroot.TabStop = false;
            btnroot.Text = "√x";
            btnroot.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450);
            Controls.Add(CalBox);
            Controls.Add(textBox);
            Controls.Add(btnroot);
            Controls.Add(btnerase);
            Controls.Add(btnclear);
            Controls.Add(btndivide);
            Controls.Add(btn9);
            Controls.Add(btnminus);
            Controls.Add(btnconvert);
            Controls.Add(btn6);
            Controls.Add(btnn);
            Controls.Add(btnplus);
            Controls.Add(btn8);
            Controls.Add(btn3);
            Controls.Add(btnfrac);
            Controls.Add(btn5);
            Controls.Add(btnPer);
            Controls.Add(btnequal);
            Controls.Add(btn7);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btndot);
            Controls.Add(btn1);
            Controls.Add(btnce);
            Controls.Add(btn0);
            Controls.Add(btnmulti);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += TextBox_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnmulti;
        private Button btn0;
        private Button btndot;
        private Button btnequal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnplus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnminus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btndivide;
        private Button btnPer;
        private Button btnn;
        private Button btnclear;
        private Button btnerase;
        private TextBox textBox;
        private TextBox CalBox;
        private Button btnce;
        private Button btnfrac;
        private Button btnconvert;
        private Button btnroot;
    }
}
