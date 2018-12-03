using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Collections
{
    public class AulaYield : IEnumerable<string>
    {
        private string st1 = "ciccio";
        private string st2 = "pippo";
        private string st3 = "pluto";

        public IEnumerator<string> GetEnumerator()
        {
            //
            yield return st1;
            //
            //
            yield return st2;
            yield return st3;
            
        }

        public IEnumerable<int> Fibonacci()
        {
            int first = 0;
            Console.WriteLine("fibo!!!");
            yield return first;
            int second = 1;
            yield return second;
            int sum;
            while(true)
            {
                sum = first + second;
                yield return sum;
                first = second;
                second = sum;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return  GetEnumerator();
        }
    }
}
