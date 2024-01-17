namespace Calculator_2
{
    public partial class Form1 : Form
    {
        private SaveNum Num { get; set; }

        public Form1()
        {
            InitializeComponent();

            this.Num = new SaveNum();

            this.btnMultiply.Click += BtnOp_Click;
            this.btnMinus.Click += BtnOp_Click;
            this.btnPlus.Click += BtnOp_Click;
            this.btnDivide.Click += BtnOp_Click;
            
            this.btnEqual.Click += Btnequal_Click;
            
            this.btnDot.Click += BtnDot_Click;
            this.btnPercentage.Click += BtnPer_Click;
            this.btnSquare.Click += BtnN_Click;
            this.btnClear.Click += BtnClear_Click;
            this.btnerase.Click += BtnErase_Click;
            this.btnConvert.Click += BtnConvert_Click;
            this.btnFraction.Click += BtnFrac_Click;
            this.btnRoot.Click += BtnRoot_Click;
            this.btnCE.Click += BtnCe_Click;

            this.btn0.Click += BtnNum_Click;
            this.btn1.Click += BtnNum_Click;
            this.btn2.Click += BtnNum_Click;
            this.btn3.Click += BtnNum_Click;
            this.btn4.Click += BtnNum_Click;
            this.btn5.Click += BtnNum_Click;
            this.btn6.Click += BtnNum_Click;
            this.btn7.Click += BtnNum_Click;
            this.btn8.Click += BtnNum_Click;
            this.btn9.Click += BtnNum_Click;


            this.textBox.Text = "0";
        }

        private void BtnPer_Click(object? sender, EventArgs e)
        {

        }

        private void BtnOp_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            double TextNum = Num.TextNum;
            double CalNum = Num.CalNum;
            double SumNum = Num.SumNum;

            if (CalBox.Text == "") // Calbox가 빈칸일 때
            {
                if ((string)button.Text == "+")
                {
                    CalBox.Text = textBox.Text + "+";
                    //textBox.Text = Convert.ToString(TextNum);
                    SumNum = Convert.ToDouble(CalBox.Text.Remove(CalBox.Text.Length - 1));
                }

                else if ((string)button.Text == "-")
                {
                    CalBox.Text = textBox.Text + "-";
                    //textBox.Text = Convert.ToString(TextNum);
                    SumNum = Convert.ToDouble(CalBox.Text.Remove(CalBox.Text.Length - 1));
                }

                else if ((string)button.Text == "×")
                {
                    CalBox.Text = textBox.Text + "×";
                    //textBox.Text = Convert.ToString(TextNum);
                    SumNum = Convert.ToDouble(CalBox.Text.Remove(CalBox.Text.Length - 1));
                }

                else if ((string)button.Text == "÷")
                {
                    CalBox.Text = textBox.Text + "÷";
                    //textBox.Text = Convert.ToString(TextNum);
                    SumNum = Convert.ToDouble(CalBox.Text.Remove(CalBox.Text.Length - 1));
                }
            }

            else if (CalBox.Text.Contains("=")) // 계산이 끝난 후
            {
                if ((string)button.Text == "+")
                {
                    CalBox.Text = SumNum + "+";
                    textBox.Text = Convert.ToString(SumNum);
                }

                else if ((string)button.Text == "-")
                {
                    CalBox.Text = SumNum + "-";
                    textBox.Text = Convert.ToString(SumNum);
                }

                else if ((string)button.Text == "×")
                {
                    CalBox.Text = SumNum + "×";
                    textBox.Text = Convert.ToString(SumNum);
                }

                else if ((string)button.Text == "÷")
                {
                    CalBox.Text = SumNum + "÷";
                    textBox.Text = Convert.ToString(SumNum);
                }
            }

            else if (TextNum == SumNum) // Calbox에 있는 숫자랑 textbox에 있는 숫자랑 같을 때
            {
                if ((string)button.Text == "+")
                {
                    CalBox.Text = CalBox.Text.Substring(0, CalBox.Text.Length - 1);
                    CalBox.Text = TextNum + "+";
                }

                else if ((string)button.Text == "-")
                {
                    CalBox.Text = CalBox.Text.Substring(0, CalBox.Text.Length - 1);
                    CalBox.Text = TextNum + "-";
                }

                else if ((string)button.Text == "×")
                {
                    CalBox.Text = CalBox.Text.Substring(0, CalBox.Text.Length - 1);
                    CalBox.Text = TextNum + "×";
                }

                else if ((string)button.Text == "÷")
                {
                    CalBox.Text = CalBox.Text.Substring(0, CalBox.Text.Length - 1);
                    CalBox.Text = TextNum + "÷";
                }
            }

            else if (TextNum != CalNum) // Calbox에 있는 숫자랑 textbox에 있는 숫자랑 다를 때 ???????????????????????
            {
                if ((string)button.Text == "+")
                {
                    CalNum = Convert.ToDouble(textBox.Text);
                    TextNum = SumNum + CalNum;
                    CalBox.Text = TextNum + "+";
                    textBox.Text = Convert.ToString(TextNum);
                }

                else if ((string)button.Text == "-")
                {
                    CalNum = Convert.ToDouble(textBox.Text);
                    TextNum = SumNum - CalNum;
                    CalBox.Text = TextNum + "-";
                    textBox.Text = Convert.ToString(TextNum);
                }

                else if ((string)button.Text == "×")
                {
                    CalNum = Convert.ToDouble(textBox.Text);
                    TextNum = SumNum * CalNum;
                    CalBox.Text = TextNum + "×";
                    textBox.Text = Convert.ToString(TextNum);
                }

                else if ((string)button.Text == "÷")
                {
                    CalNum = Convert.ToDouble(textBox.Text);
                    TextNum = SumNum / CalNum;
                    CalBox.Text = TextNum + "÷";
                    textBox.Text = Convert.ToString(TextNum);
                }
            }
            else
            {
                switch (button.Text)
                {
                    case "+":
                        CalNum = Convert.ToDouble(textBox.Text);
                        TextNum = SumNum + CalNum;
                        CalBox.Text = TextNum + "+";
                        textBox.Text = Convert.ToString(TextNum);
                        break;
                    case "-":
                        CalNum = Convert.ToDouble(textBox.Text);
                        TextNum = SumNum - CalNum;
                        CalBox.Text = TextNum + "-";
                        textBox.Text = Convert.ToString(TextNum);
                        break;
                    case "×":
                        CalNum = Convert.ToDouble(textBox.Text);
                        TextNum = SumNum * CalNum;
                        CalBox.Text = TextNum + "×";
                        textBox.Text = Convert.ToString(TextNum);
                        break;
                    case "÷":
                        CalNum = Convert.ToDouble(textBox.Text);
                        TextNum = SumNum / CalNum;
                        CalBox.Text = TextNum + "÷";
                        textBox.Text = Convert.ToString(TextNum);
                        break;
                }
            }
            CalNum = Convert.ToDouble(CalBox.Text.Remove(CalBox.Text.Length - 1));
            TextNum = Convert.ToDouble(textBox.Text);
            Num.TextNum = TextNum;
            Num.SetNum(ref CalNum, ref TextNum, ref SumNum);
        }

        private void BtnErase_Click(object? sender, EventArgs e)
        {
            Erase();
        }

        public void Erase()
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            if (textBox.Text.Length == 0)
            {
                textBox.Text = "0";
            }
            Num.TextNum = Convert.ToDouble(textBox.Text);
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            textBox.Text = "0";
            CalBox.Text = "";
            double Re = 0;
            Num.SetNum(ref Re, ref Re, ref Re);
        }

        private void BtnCe_Click(object? sender, EventArgs e)
        {
            Clear_E();
        }

        public void Clear_E()
        {
            if (CalBox.Text != null)
                CalBox.Text = "";
            textBox.Text = "0";
            Num.TextNum = 0;
        }

        private void BtnFrac_Click(object? sender, EventArgs e)
        {
            double TextNum = Num.TextNum;
            CalBox.Text = "1/(" + textBox.Text + ")";
            textBox.Text = Convert.ToString(1 / TextNum);
            double SumNum = Convert.ToDouble(textBox.Text);
            Num.SumNum = SumNum;
        }

        private void BtnN_Click(object? sender, EventArgs e)
        {
            double TextNum = Num.TextNum;
            CalBox.Text = "sqr(" + textBox.Text + ")";
            textBox.Text = Convert.ToString(TextNum * TextNum);
            double SumNum = Convert.ToDouble(textBox.Text);
            Num.SumNum = SumNum;
        }

        private void BtnRoot_Click(object? sender, EventArgs e)
        {
            double TextNum = Num.TextNum;
            CalBox.Text = "√(" + textBox.Text + ")";
            textBox.Text = Convert.ToString(Math.Sqrt(TextNum));
            double SumNum = Convert.ToDouble(textBox.Text);
            Num.SumNum = SumNum;
        }

        private void BtnDot_Click(object? sender, EventArgs e)
        {
            Dot();
        }

        public void Dot()
        {
            if (textBox.Text.Contains(".") == false)
            {
                textBox.AppendText(".");
            }
            double TextNum = Convert.ToDouble(textBox.Text);
            Num.TextNum = TextNum;
        }

        private void BtnConvert_Click(object? sender, EventArgs e)
        {
            double Text1 = Convert.ToDouble(textBox.Text);
            Text1 *= -1;

            textBox.Text = Convert.ToString(Text1);
        }

        private void Btnequal_Click(object? sender, EventArgs e)
        {
            Operator op = new Operator(this.Num);

            string equal = CalBox.Text.Substring(CalBox.Text.Length - 1);

            switch (equal)
            {
                case "÷":
                    textBox.Text = Convert.ToString(op.Divide());
                    CalBox.AppendText(Convert.ToString(this.Num.TextNum) + "=");
                    break;
                case "×":
                    textBox.Text = Convert.ToString(op.Multiply());
                    CalBox.AppendText(Convert.ToString(this.Num.TextNum) + "=");
                    break;
                case "-":
                    textBox.Text = Convert.ToString(op.Minus());
                    CalBox.AppendText(Convert.ToString(this.Num.TextNum) + "=");
                    break;
                case "+":
                    textBox.Text = Convert.ToString(op.Plus());
                    CalBox.AppendText(Convert.ToString(this.Num.TextNum) + "=");
                    break;
                default:
                    break;
            }
        }

        private void BtnNum_Click(object? sender, EventArgs e)
        {
            Button NumBtn = (Button)sender;
            SetNum(NumBtn.Text);
            textBox.Select(textBox.Text.Length, 0);
            // double TextNum = Convert.ToDouble(textBox.Text);
            // op.SetTextNum(ref TextNum);
        }  // 버튼을 눌렀을 때

        public void SetNum(string num)
        {
            double SumNum = this.Num.SumNum;
            double CalNum = this.Num.CalNum;
            double TextNum = this.Num.TextNum;

            if (textBox.Text == "0")
            {
                textBox.Text = num;
            }
            else if (CalBox.Text.Contains("="))
            {
                CalBox.Text = null;
                textBox.Text = num;
            }
            else if (TextNum == SumNum || TextNum == CalNum)
            {
                textBox.Text = num;
            }
            else if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += num;
            }
            TextNum = Convert.ToDouble(textBox.Text);
            this.Num.SetNum(ref CalNum, ref TextNum, ref SumNum);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string Num;
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    Num = "1";
                    SetNum(Num);
                    break;
                case Keys.NumPad2:
                    Num = "2";
                    SetNum(Num);
                    break;
                case Keys.NumPad3:
                    Num = "3";
                    SetNum(Num);
                    break;
                case Keys.NumPad4:
                    Num = "4";
                    SetNum(Num);
                    break;
                case Keys.NumPad5:
                    Num = "5";
                    SetNum(Num);
                    break;
                case Keys.NumPad6:
                    Num = "6";
                    SetNum(Num);
                    break;
                case Keys.NumPad7:
                    Num = "7";
                    SetNum(Num);
                    break;
                case Keys.NumPad8:
                    Num = "8";
                    SetNum(Num);
                    break;
                case Keys.NumPad9:
                    Num = "9";
                    SetNum(Num);
                    break;
                case Keys.NumPad0:
                    Num = "0";
                    SetNum(Num);
                    break;
                case Keys.Add:

                    break;
                case Keys.Subtract:
                    break;
                case Keys.Multiply:
                    break;
                case Keys.Divide:
                    break;
                case Keys.Delete:
                    Clear_E();
                    break;
                case Keys.Back:
                    Erase();
                    break;
                case Keys.Enter:

                    break;
                case Keys.Decimal:
                    Dot();
                    break;
                default: break;
            }
        }
    }
}