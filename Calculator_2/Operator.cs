using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class Operator
    {
        private SaveNum SaveNum { get; set; }

        public Operator(SaveNum saveNum)
        {
            this.SaveNum = saveNum;
        }

        public double Plus()
        {
            return this.SaveNum.TextNum + this.SaveNum.CalNum;
        }

        public double Minus()
        {
            return this.SaveNum.TextNum - this.SaveNum.CalNum;
        }

        public double Divide()
        {
            return this.SaveNum.TextNum / this.SaveNum.CalNum;
        }

        public double Multiply()
        {
            return this.SaveNum.TextNum * this.SaveNum.CalNum;
        }        
        
    }
}
