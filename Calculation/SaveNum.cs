using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class SaveNum
    {
        private double calnum = 0; // calbox
        private double textnum = 0; // new textbox
        private double sumnum = 0; // textbox
        private double savetextnum = 0; // = 계산할 때 얘에다가 textnum저장해서 계속 계산하게 만드는게 나의 목표임

        public SaveNum()
        {

        }

        // Property
        public double CalNum
        {
            get
            {
                return this.calnum;
            }

            set
            {
                this.calnum = value;
            }
        }

        public double TextNum
        {
            get
            {
                return this.textnum;
            }

            set
            {
                this.textnum = value;
            }
        }
        
        public double SumNum
        {
            get
            {
                return this.sumnum;
            }

            set
            {
                this.sumnum = value;
            }
        }

        public double SaveTextNum
        {
            get
            {
                return this.savetextnum;
            }

            set
            {
                this.savetextnum = value;
            }
        }

        // Event (Delegatge) 이걸로 멀 추가하랬지? 머,, 생각나면 하지 머,,,

        public void SetNum(ref double CalNum, ref double textnum, ref double SumNum)
        {
            this.calnum = CalNum;
            this.textnum = textnum;
            this.sumnum = SumNum;
        }
    }
}
