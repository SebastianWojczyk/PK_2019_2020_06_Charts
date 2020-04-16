using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Charts
{
    interface IFunction
    {
        string FunctionName
        {
            get;
        }
        double Value(double x);
        event emptyFunction FunctionChanged;
    }
    public delegate void emptyFunction();
}
