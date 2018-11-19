using System;

namespace HelloDotNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Iterations();
            //Recursion(1);
            //  FibonacciIterative();
            // FibonacciRecursion();
            Arrays();
       
        }

        

        static void Conditionals()
        {
            int number = 10;
            Console.WriteLine("il numero è " + number);
            if (number < 10)
            {
                Console.WriteLine("il numero è minore di 10");
            }
            else if (number == 10)
            {
                Console.WriteLine("il numero è uguale a 10");
            }
            else
            {
                Console.WriteLine("il numero è maggiore di 10");
            }
        }
        static void Iterations()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            int k = 1;
            while(k<=10)
            {
                Console.WriteLine(k++);
               // k++;
            }
            k = 1;
            do
            {
                Console.WriteLine(k++);
            }
            while (k<=10);
        }
        static void Recursion(int n)
        {
            Console.WriteLine(n);
            n++;
            if (n<=10)
            {
                Recursion(n);
            }
        }
        static void FibonacciIterative()
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for(int i=0;i<8;i++)
            {
                int somma = n1 + n2;
                n1 = n2;
                n2 = somma;
                Console.WriteLine(somma);
            }
        }
        private static void FibonacciRecursion()
        {
           for(int i=0;i<10;i++)
            {
                int fib = Fibo(i);
                Console.WriteLine(fib);
            }
        }

        private static int Fibo(int i)
        {
            if(i==0)
            {
                return 0;
            }
            if(i==1)
            {
                return 1;
            }
            return Fibo(i - 1) + Fibo(i - 2);
        }
        static void Arrays()
        {
            int n;
            int[] myNumbers = new int[10];
            for(int i=0;i<myNumbers.Length;i++)
            {
                //n = myNumbers[i];
                myNumbers[i] = (int) Math.Pow(2, i);
                Console.WriteLine(myNumbers[i]);
            }
            // myNumbers[myNumbers.Length - 1] = 0;
            // bool result = IsSorted(myNumbers);
            bool result = Contains(myNumbers, 1);
            bool binaryResult = BinarySearch(myNumbers, 1, 0, myNumbers.Length - 1);
            Console.WriteLine(result);
            Console.WriteLine(binaryResult);

            //Console.WriteLine(myNumbers);
            //foreach (int num in myNumbers)
            //{
            //    //Console.WriteLine(num);
            //    num = 5;
            //}
        }
        static bool IsSorted(int[] array)
        {
            for(int i=1;i<array.Length;++i)
            {
                if (array[i]<array[i-1])
                {
                    return false;
                }
            }
            return true;
        }
        static bool Contains(int[] array, int a)
        {
            foreach (int item in array)
            {
                if (item==a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool BinarySearch(int[] array, int a, int start, int end)
        {
            if (end<start)
            {
                return false;
            }
            int pos = (start + end) / 2;
            int pivot = array[pos];
            if (pivot == a)
            {
                return true;
            }
            else if (pivot < a)
            {
                return BinarySearch(array, a, pos+1, end);
            }
            else
            {
                return BinarySearch(array, a, start, pos-1);
            }
        }
    }

}
