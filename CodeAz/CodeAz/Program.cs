using System;
using System.IO;

namespace CodeAz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşçi sayı daxil edin: ");
            string str = Console.ReadLine();
            int x = Convert.ToInt32(str);
            Employee[] employees = new Employee[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"{i+1}. İşçinin adını daxil edin: ");
                string fullName = Console.ReadLine();
                Console.WriteLine($"{i+1}. İşçinin yaşını daxil edin: ");
                string ageStr = Console.ReadLine();
                int ageInt = Convert.ToInt32(ageStr);
                Console.WriteLine($"{i+1}. İşçinin maaşını daxil edin: ");
                string salary = Console.ReadLine();
                int salInt = Convert.ToInt32(salary);
                Console.WriteLine($"{i+1}. İşçinin pozisiyasını daxil edin: ");
                string position = Console.ReadLine();
                employees[i] = new Employee(fullName, ageInt, salInt, position);
            }
            Console.WriteLine("Filtirləmə aparmaq istəyirsinizmi? Yes/No");
            string check = Console.ReadLine();
            if (check.Equals("Yes"))
            {
                Console.WriteLine("Minimum maaş daxil edin: ");
                string minStr = Console.ReadLine();
                Console.WriteLine("Maksimum maaş daxil edin: ");
                string maxStr = Console.ReadLine();
                int minSal = Convert.ToInt32(minStr);
                int maxSal = Convert.ToInt32(maxStr);
                Console.WriteLine("Filtrlənmiş işçilər: ");
                for (int i = 0; i < x; i++)
                {
                    if (employees[i].Salary >= minSal && employees[i].Salary <= maxSal)
                    {
                        employees[i].showInfo();
                    }
                }
            }
            else
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("İşçilər: ");
                    employees[i].showInfo();
                }
            }
        }
    }
}