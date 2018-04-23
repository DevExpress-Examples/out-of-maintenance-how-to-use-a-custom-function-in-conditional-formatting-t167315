using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterOperationExample
{
    public class CustomFunction : ICustomFunctionOperator
    {
        public object Evaluate(params object[] operands)
        {
            var result = Convert.ToInt32(operands[0]) / Convert.ToInt32(operands[1]);

            if (result == Convert.ToInt32(operands[2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Name
        {
            get { return "Function"; }
        }

        public Type ResultType(params Type[] operands)
        {
            return typeof(bool);
        }
    }
}
