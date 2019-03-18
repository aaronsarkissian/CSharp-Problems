using System;

namespace MinValue
{
    class Program
    {
        public static int MinValue(params int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if(arr.Length == 0)
            {
                throw new ArgumentException($"'{nameof(arr)}' length should be greater than 0", nameof(arr));
            }

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
            int[] array = new int[10];

            try
            {
                Console.WriteLine(MinValue(6, 7, 2, -3, -1, -4, 1, 0, -5, 10));
                //Console.WriteLine(MinValue(null));
                //Console.WriteLine(MinValue(array)); // Should we handle this case?
                //Console.WriteLine(MinValue());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
