using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Collections
{
    public class PairOf<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public PairOf(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        //public PairOf()
        //{
        //}

        public void Print()
        {
            Console.WriteLine($"First: {First}, Second: {Second}");
        }
    }
}
