using System;

namespace PasswordGenerator
{
    public class PasswordGenerator
    {
        static Random rand = new Random();
        private int Length { get; }

        public PasswordGenerator()
        {
            Length = 8;
        }

        public PasswordGenerator(int length)
        {
            try
            {
                length = Convert.ToInt32(length);

                if (length < 8)
                {
                    Length = 8;
                }
                else
                {
                    Length = length;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public PasswordGenerator(char charLength)
        {
            try
            {
                int length = charLength - '0';

                if (length < 8)
                {
                    Length = 8;
                }
                else
                {
                    Length = length;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        private char RandomChar()
        {
            return (char)rand.Next(33, 127); // All standard and visible ASCII characters
        }

        public string Generate()
        {
            char[] Pass = new char[Length];

            for (int i = 0; i < Length; i++)
            {
                Pass[i] = RandomChar();
            }

            return new string(Pass);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PasswordGenerator pg1 = new PasswordGenerator();
                Console.WriteLine(pg1.Generate());
                PasswordGenerator pg2 = new PasswordGenerator(25);
                Console.WriteLine(pg2.Generate());
                PasswordGenerator pg3 = new PasswordGenerator('9');
                Console.WriteLine(pg3.Generate());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
