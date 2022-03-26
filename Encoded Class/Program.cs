using Encoder;
using System;

namespace Encoded_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;

            while (isActive == true)
            {
                Console.Write("Enter Password For Hashing : ");
                Console.ForegroundColor = ConsoleColor.Green;
                string Password = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                string PasswordHash = Password.EncodeToMd5();
                Console.WriteLine("==========================================================");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result : " + PasswordHash);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("==========================================================");

            }

            //Console.ReadKey();

        }
    }
}
