using System;
namespace PasswordGenerator {

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome how long would you like your password to be?");
            int length;
            length = Console.ReadLine();
            if (length ==null)
            {
                return;
            }
            if (length < 8)
            {
                
            }
            Console.WriteLine("Creating a password {length} digits long");
            string password;
            password = passwordGen(length);

        }
        static string passwordGen(int length)
        {
            string generatedPassword = "";
            string upperLetter = makeUpperLetter();
            string lowerLetter = makeUpperLetter();
            string randNumber = makeNumber();
            string special = makeSpecial();


            return generatedPassword;
        }
    }

}