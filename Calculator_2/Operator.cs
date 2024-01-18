using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class Operator
    {
        private double calnum;
        private double textnum;
        private double sumnum;
        
        public double Plus()
        {
            sumnum = this.OnPlus(this.textnum, this.calnum);
            return sumnum;
        }

        private double OnPlus(double a, double b)
        {
            return a + b;
        }

        public double Miuns()
        {
            sumnum = this.OnMinus(this.calnum, this.textnum);
            return sumnum;
        }

        private double OnMinus(double a, double b)
        {
            return a - b;
        }

        public double Divide()
        {
            sumnum = this.OnDivide(this.calnum, this.textnum);
            return sumnum;
        }

        private double OnDivide(double a, double b)
        {
            return a / b;
        }

        public double Multi()
        {
            sumnum = this.OnMulti(this.calnum, this.textnum);
            return sumnum;
        }

        private double OnMulti(double a, double b)
        {
            return a * b;
        }
    }
}
