using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;

            Console.WriteLine("Welcome, how long would you like your password to be?");

            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Try again with a number");
            }

            if (length < 8)
            {
                Console.WriteLine("Length needs to be at least 8.");
                length = 8;
            }


            Console.WriteLine("Creating a password " + length + " characters long");
            string password = PasswordGen(length);
            Console.WriteLine("Your password is: " + password);

        }

        static string PasswordGen(int length)
        {
            char[] chars = new char[length];
            chars[0] = makeUpperLetter();
            chars[1] = makeLowerLetter();
            chars[2] = makeNumber();
            chars[3] = makeSpecial();

            Random rand = new Random();

            for (int i = 4; i < length; i++)
            {
                int num = rand.Next(0, 4);
                char letter;
                switch (num)
                {
                    case 0:
                        letter = makeLowerLetter();
                        break;
                    case 1:
                        letter = makeUpperLetter();
                        break;
                    case 2:
                        letter = makeNumber();
                        break;
                    default:
                        letter = makeSpecial();
                        break;
                }
                chars[i] = letter;
            }

            var rng = new Random();
            rng.Shuffle(chars);

            return new string(chars);
        }

        static char makeUpperLetter()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }

        static char makeLowerLetter()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }

        static char makeNumber()
        {
            string chars = "1234567890";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }

        static char makeSpecial()
        {
            string chars = "$%#@!*?;:^&";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }
    }

    public static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
