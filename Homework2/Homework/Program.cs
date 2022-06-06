using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student
            {
                FullName = "Nihad Alakbarzade",
                GroupNo = "P227"
            };
            Student std1 = new Student
            {
                FullName = "Nihad asd",
                GroupNo = "123",
            };
            Console.WriteLine($"Name: {std.FullName} - GroupNo: {std.GroupNo} - No: {std._no}");

            Console.WriteLine($"Name: {std1.FullName} - GroupNo: {std1.GroupNo} - No: {std1._no}");
        }
    }
}