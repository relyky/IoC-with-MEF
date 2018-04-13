using System;

namespace mefPractices01
{
    public interface IMyBizPartA
    {
        Decimal OperandA { get; set; }
        Decimal OperandB { get; set; }
        Decimal Result { get; }

        void Add();
    }
}
