using System;
using System.IO;

namespace CodeAz
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[5];
            notebooks[0] = new Notebook("asd", "asd", 5.5);
            notebooks[1] = new Notebook("dfg", "asdsd", 65);
            notebooks[2] = new Notebook("hhj", "eqw", 1.25);
            notebooks[3] = new Notebook("asdds", "5te3", 12);
            notebooks[4] = new Notebook("bvd", "nrth", 16);
            Console.WriteLine("Enter a minimum price: ");
            string numStr = Console.ReadLine();
            int minPrice = Convert.ToInt32(numStr);
            Console.WriteLine("Enter a maximum price: ");
            string numStrNew = Console.ReadLine();
            int maxPrice = Convert.ToInt32(numStrNew);
            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price > minPrice && notebooks[i].Price < maxPrice)
                {
                    Console.WriteLine(notebooks[i].Name);
                }
            }

            Car car = new Car("BMW", "i328", 40, 1, 30);
            car.Drive(20);
        }
    }
}