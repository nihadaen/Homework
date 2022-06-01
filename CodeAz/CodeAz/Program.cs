using System;
using System.IO;

namespace CodeAz
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Username daxil edin: ");
            user.SetUsername(Console.ReadLine());
            Console.WriteLine("Password daxil edin: ");
            user.SetPassword((Console.ReadLine()));

            Console.WriteLine($"Username: {user.GetUsername()}");
            Console.WriteLine($"Password: {user.GetPassword()}");
        }
    }
}