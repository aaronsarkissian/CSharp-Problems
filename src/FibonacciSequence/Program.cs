using System;
using System.Collections;

namespace FibonacciSequence
{
    public class FibonacciSequenceGen : IEnumerable
    {
        private int Len { get; set; }

        public FibonacciSequenceGen(int size)
        {
            Len = size;
        }

        public IEnumerator GetEnumerator()
        {
            int n0 = 0;
            int n1 = 1;
            int count = 0;

            while(count < Len)
            {
                int tmp = n0;
                n0 = n1;
                n1 = tmp + n1;
                ++count;

                yield return n1 - n0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fib = new FibonacciSequenceGen(20);

            foreach (var num in fib)
            {
                Console.Write($"{num}, ");
            }
        }
    }
}
