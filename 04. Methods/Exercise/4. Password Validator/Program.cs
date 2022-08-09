using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (NumOfCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (CheckOnlyDigetsAndLetters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (DigitCheck(password) != true)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (DigitCheck(password) && CheckOnlyDigetsAndLetters(password) != true && NumOfCharacters(password) != true)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool NumOfCharacters(string password)
        {
            bool check = false;
            if (password.Length < 6 || password.Length > 10)
            {
                check = true;
            }
            return check;
        }
        static bool CheckOnlyDigetsAndLetters(string password)
        {
            bool check = false;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] < 'a' || password[i] > 'z') && (password[i] < '0' || password[i] > '9'))
                {
                    if (password[i] < 'A' || password[i] > 'Z')
                    {
                        check = true;
                        return check;
                    }
                }
            }
            return check;
        }
        static bool DigitCheck(string password)
        {
            bool check = false;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    counter++;
                    if (counter >= 2)
                    {
                        check = true;
                        break;
                    }
                }
            }
            return check;
        }
    }
}
