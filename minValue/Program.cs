using System;

namespace minValue
{
    class Program
    {
        public static int minValue(int[] arr)
        {
            Array.Sort(arr);
            return arr[0];
        }

        // More Manual Solution
        public static int minValue2(int[] arr)
        {
            int min = arr[0];
            foreach(int i in arr)
            {
                if(i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            int[] array = { 6, 7, 2, -3, -1, -4, 1, 0, -5, 10 };
            Console.WriteLine(minValue(array));
            Console.WriteLine(minValue2(array));
        }
    }
}
