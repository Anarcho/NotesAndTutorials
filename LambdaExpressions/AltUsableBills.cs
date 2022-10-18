using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class AltUsableBills : TestLambdaClass
    {
        public bool CanWorkWithoutResource = false;
        public bool AllResourceTraderOn = true;

        public string testString() => "test " + "this";
    }
}
