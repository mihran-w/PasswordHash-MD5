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
                Console.WriteLine("Enter Password For Hashing :");
                string Password = Console.ReadLine();
                string PasswordHash = Password.EncodeToMd5();
                Console.WriteLine(PasswordHash);
            }

            //Console.ReadKey();

        }
    }
}
