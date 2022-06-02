using System;
using ClassLibrary;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department(3);
            
            department.AddEmployee(new Employee(){Name = "Nihad", Surname = "Alakbarzade", Salary = 260});
            foreach (var i in department.Employees)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Surname);
                Console.WriteLine(i.Salary);
            }
        }
    }
}