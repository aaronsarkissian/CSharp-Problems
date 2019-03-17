using System;

namespace IsPalindrome
{
    class Program
    {
        public static bool IsPalidrome(string str)
        {
            str = str.ToUpper();

            for (var i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write(IsPalidrome("Deleveled"));
        }
    }
}
