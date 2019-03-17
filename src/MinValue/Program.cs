using System;

namespace MinValue
{
    class Program
    {
        public static int MinValue(params int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MinValue(6, 7, 2, -3, -1, -4, 1, 0, -5, 10));
        }
    }
}
