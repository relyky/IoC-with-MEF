using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBizPartB
{
    [Export(typeof(mefPractices01.IMyBizPartB))]
    public class MyBizPartB : mefPractices01.IMyBizPartB
    {
        public string WhoAmI
        {
            get { return "I come from Taiwan."; }
        }

        public MyBizPartB()
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

        public void Mul()
        {
            this.Result = this.OperandA * this.OperandB;
        }

    }
}