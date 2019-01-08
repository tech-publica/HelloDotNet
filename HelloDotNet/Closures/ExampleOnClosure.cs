using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Closures
{
    public class ExampleOnClosure
    {

        public static Func<double, double> MultiplyBy(double factor)
        {
            return x => x * factor;
        }
    }
}
