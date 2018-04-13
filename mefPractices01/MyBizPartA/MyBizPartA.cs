using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBizPartA 
{
    public class MyBizPartA : mefPractices01.IMyBizPartA
    {
        public MyBizPartA()
        { }

        public Decimal OperandA
        {
            get;
            set;
        }

        public Decimal OperandB
        {
            get;
            set;
        }

        public Decimal Result
        {
            get;
            protected set;
        }

        public void Add()
        {
            this.Result = this.OperandA + this.OperandB;
        }

    }
}
