using System;

namespace Hw1
{
    public class Student : Human
    {
        public int Grade;
        public string GroupNo;

        public Student(string name, string surname):base(name, surname)
        {
            
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"FullName: {Name} {Surname} - Age: {Age} - Grade: {Grade} - GroupNo: {GroupNo}");
        }
    }
}