using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace mefPractices01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBizModule biz = new MyBizModule();
            Decimal resultA = biz.CallMyBehaviorA(7, 8);
            Decimal resultB = biz.CallMyBehaviorB(7, 8);

            // 
            Console.WriteLine("Rsult: {0}", resultA);
            Console.WriteLine("Rsult: {0}", resultB);

            // exit
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
