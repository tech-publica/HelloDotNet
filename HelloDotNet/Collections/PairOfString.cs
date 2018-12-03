using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Collections
{
    public class PairOfString
    {
        public string First { get; set; }
        public string Second { get; set; }

        public PairOfString(string first, string second)
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
