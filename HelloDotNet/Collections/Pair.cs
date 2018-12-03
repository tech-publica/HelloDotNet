using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Collections
{
    public class Pair
    {
        public object First { get; set; }
        public object Second { get; set; }

        public Pair(object first, object second)
        {
            First = first;
            Second = second;
        }

        public void Print()
        {
            Console.WriteLine($"First: {First}, Second: {Second}");
        }

    }
}
