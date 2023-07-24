using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cSharp_lambdaExpressions.Program;

namespace cSharp_lambdaExpressions
{
    internal class someClass
    {
        public someClass(MathOperation mathOperation)
        {
            int result = mathOperation(5, 2);
        }
    }
}
