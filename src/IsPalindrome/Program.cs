using System;

namespace IsPalindrome
{
    class Program
    {
        public static bool IsPalidrome(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                throw new ArgumentException($"'{nameof(str)}' length should be greater than 0", nameof(str));
            }

            str = str.ToUpper();

            for (var i = 0; i < str.Length / 2; i++)
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
            try
            {
                Console.Write(IsPalidrome("Deleveled"));
                Console.Write(IsPalidrome(null));
                Console.Write(IsPalidrome(""));
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
