using System;

namespace CodeAz
{
    public class Employee:Human
    {
        public int Salary;
        public string Position;

        public Employee(string fullName, int age, int salary, string position) : base(fullName, age)
        {
            Salary = salary;
            Position = position;
        }

        public void showInfo()
        {
            Console.WriteLine($"Full Name: {FullName} - Age: {Age} - Salary: {Salary} - Position: {Position}");
        }
    }
}