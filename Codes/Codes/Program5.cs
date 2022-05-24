using System;
using System.Linq;

namespace CodeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a username: ");
            String username = Console.ReadLine();
            while (username.ToCharArray().Any(char.IsDigit))
            {
                Console.WriteLine("Try Again: ");
                username = Console.ReadLine();
            }
            Console.WriteLine("All good " + username);
        }
    }
}

