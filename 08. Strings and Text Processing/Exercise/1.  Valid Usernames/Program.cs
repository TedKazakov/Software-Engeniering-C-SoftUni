using System;

namespace _1.__Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var username in usernames)
            {
                bool check = true;
                if (username.Length >= 3 && username.Length < 17)
                {
                    foreach (var letter in username)
                    {
                        if (!char.IsLetter(letter) && !char.IsDigit(letter) && letter != '-' && letter != '_')
                        {
                            check = false;
                            break;
                        }
                    }
                }
                else check = false;
                if (check)
                {
                    Console.WriteLine(username);
                }

            }


        }
    }
}
