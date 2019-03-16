using System;

namespace IsPalindrome
{
    class Program
    {
        public static bool IsPalidrome(string str)
        {
            str = str.ToLower();
            var strLen = str.Length;

            for (var i = 0; i < strLen; i++)
            {
                if (str[i] != str[strLen - 1 - i])
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
