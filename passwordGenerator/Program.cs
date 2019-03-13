using System;

namespace passwordGenerator
{
    public class PasswordGenerator
    {
        private string Password { get; set; }
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
            Random rand = new Random();
            return (char)rand.Next(33, 127); // All Standard and visible ASCII characters
        }

        public string Generate()
        {
            for(int i = 0; i < Length; i++)
            {
                Password += RandomChar();
            }
            return Password;
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
