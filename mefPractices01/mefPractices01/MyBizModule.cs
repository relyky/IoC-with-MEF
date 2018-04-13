using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace mefPractices01
{
    /// <summary>
    /// 模擬商業邏輯層
    /// </summary>
    class MyBizModule
    {
        /// <summary>
        /// 將在 Import 時建構並 asign 到此
        /// </summary>
        [Import(typeof(IMyFactory))]
        protected IMyFactory myFactory { get; set; }

        /// <summary>
        /// 將在 Import 時建構並 asign 到此
        /// </summary>
        [Import(typeof(IMyBizPartB))]
        protected IMyBizPartB partB { get; set; } 

        public MyBizModule()
        {
            //## 組合元件 with MEF
            /// 組合MEF的動作一般是在 application loading 時期完成，也就是 application 啟動後第一件事。
            var catalog = new DirectoryCatalog(@".\");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        /// <summary>
        /// 模擬商業行為
        /// </summary>
        public Decimal CallMyBehaviorA(Decimal opA, Decimal opB)
        {
            //## 透過 factory 建構 part A.
            IMyBizPartA partA = myFactory.CreateMyBizPartA();

            //## 使用 part A.
            /// part A, part B 用以模擬演算法層
            partA.OperandA = opA;
            partA.OperandB = opB;
            partA.Add();
            return partA.Result;
        }

        /// <summary>
        /// 模擬商業行為
        /// </summary>
        public Decimal CallMyBehaviorB(Decimal opA, Decimal opB)
        {
            //## 可直接使用 part B，因為在"Import"時已建構。
            /// part A, part B 用以模擬演算法層
            partB.OperandA = opA;
            partB.OperandB = opB;
            partB.Mul();
            return partB.Result;
        }

    }
}
