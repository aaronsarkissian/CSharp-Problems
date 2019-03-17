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
            Length = length;
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
            PasswordGenerator pg1 = new PasswordGenerator();
            Console.WriteLine(pg1.Generate());
            PasswordGenerator pg2 = new PasswordGenerator(25);
            Console.WriteLine(pg2.Generate());
        }
    }
}
