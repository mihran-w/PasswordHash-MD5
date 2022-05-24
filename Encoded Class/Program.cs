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

            // site MD5 : 81dc9bdb52d04dc20036dbd8313ed055
            // this MD5 : 81-DC-9B-DB-52-D0-4D-C2-00-36-DB-D8-31-3E-D0-55

        }
    }
}
