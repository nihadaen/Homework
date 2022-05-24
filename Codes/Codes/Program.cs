using System;

namespace Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Abbas", "Nihad", "Ayan", "Samir" };
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][0] == 'A')
                    count++;
            }
            Console.WriteLine("A ilə başlayan sözlər sayı: " + count);
        }
    }
}
