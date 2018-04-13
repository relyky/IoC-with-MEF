using System;

namespace mefPractices01
{
    public interface IMyBizPartB
    {
        String WhoAmI { get; }

        Decimal OperandA { get; set; }
        Decimal OperandB { get; set; }
        Decimal Result { get; }

        void Mul();
    }
}
