using System;

namespace Hw1
{
    public class Employee:Human
    {
        public string Position;

        public Employee(string name, string surname):base(name,surname)
        {
            
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"FullName: {Name} {Surname} - Age: {Age} - Position: {Position}");
        }
    }
}