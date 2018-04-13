using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBizPartA
{
    /// <summary>
    /// Abstract Factory Pattern
    /// </summary>
    [Export(typeof(mefPractices01.IMyFactory))]
    public class MyFactory : mefPractices01.IMyFactory
    {
        public mefPractices01.IMyBizPartA CreateMyBizPartA()
        {
            return new MyBizPartA();
        }

        //public mefPractices01.IMyBizPartB CreateMyBizPartB()
        //{
        //    return new MyBizPartB();
        //}

        //public mefPractices01.IMyBizPartC CreateMyBizPartC()
        //{
        //    return new MyBizPartC();
        //}
    }
}
