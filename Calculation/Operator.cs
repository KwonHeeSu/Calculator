using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class Operator
    {
        private SaveNum Num { get; set; }

        public Operator(SaveNum num)
        {
            this.Num = num;
        }
        
        public double Plus()
        {
            this.Num.SumNum = this.OnPlus(this.Num.CalNum, this.Num.TextNum);
            return this.Num.SumNum;
        }

        private double OnPlus(double a, double b)
        {
            return a + b;
        }

        public double Miuns()
        {
            this.Num.SumNum = this.OnMinus(this.Num.CalNum, this.Num.TextNum);
            return this.Num.SumNum;
        }

        private double OnMinus(double a, double b)
        {
            return a - b;
        }

        public double Divide()
        {
            this.Num.SumNum = this.OnDivide(this.Num.CalNum, this.Num.TextNum);
            return this.Num.SumNum;
        }

        private double OnDivide(double a, double b)
        {
            return a / b;
        }

        public double Multi()
        {
            this.Num.SumNum = this.OnMulti(this.Num.CalNum, this.Num.TextNum);
            return this.Num.SumNum;
        }

        private double OnMulti(double a, double b)
        {
            return a * b;
        }
    }
}
