using System;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Baku baku = new Baku();
            string opt;
            do
            {
                Console.WriteLine("1. Employee əlavə et");
                Console.WriteLine("2. Student əlavə et");
                Console.WriteLine("3. Employeelərin sayını göstər");
                Console.WriteLine("4. Studentlərin sayını göstər");
                Console.WriteLine("5. Employeelərə bax");
                Console.WriteLine("6. Studentlərə bax");
                Console.WriteLine("7. İnsanlar üzərində axtarış et");
                Console.WriteLine("0. Menudan çıx");
                opt = Console.ReadLine();
                try
                { 
                    if (opt == "1")
                    {
                        Console.WriteLine("Ad daxil edin: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Soyad daxil edin: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Yaş daxil edin: ");
                        string age = Console.ReadLine();
                        int ageInt = Convert.ToInt32(age);
                        Console.WriteLine("Position daxil edin: ");
                        string position = Console.ReadLine();
                        Employee emp = new Employee(name, surname)
                    {
                        Age = ageInt,
                        Position = position
                    };
                    baku.AddHuman(emp);
                    }
                    else if (opt == "2") 
                    {
                        Console.WriteLine("Ad daxil edin: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Soyad daxil edin: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Yaş daxil edin: ");
                        string age = Console.ReadLine();
                        int ageInt = Convert.ToInt32(age);
                        Console.WriteLine("Grade daxil edin: ");
                        string grade = Console.ReadLine();
                        int gradeInt = Convert.ToInt32(grade);
                        Console.WriteLine("GroupNo daxil edin: ");
                        string groupNo = Console.ReadLine();
                        Student std = new Student(name, surname) 
                        {
                        Age = ageInt,
                        Grade = gradeInt,
                        GroupNo = groupNo 
                        }; 
                        baku.AddHuman(std); 
                    }
                    else if (opt == "3") 
                    { 
                        Console.WriteLine("Employeelərin sayı: " + baku.GetEmpCount()); 
                    }
                    else if (opt == "4")
                    {
                        Console.WriteLine("Studentlərin sayı: " + baku.GetStdCount());
                    }
                    else if (opt == "5") 
                    { 
                        for (int i = 0; i < baku.GetEmployees().Length; i++) 
                        { 
                            baku.GetEmployees()[i].ShowInfo(); 
                        } 
                    }
                    else if (opt == "6") 
                    { 
                        for (int i = 0; i < baku.GetStudents().Length; i++) 
                        { 
                            baku.GetStudents()[i].ShowInfo(); 
                        } 
                    }
                    else if (opt == "7") 
                    { 
                        Console.WriteLine("Axtarış dəyəri qeyd edin: "); 
                        string search = Console.ReadLine(); 
                        for (int i = 0; i < baku.SearchHumans(search).Length; i++) 
                        { 
                            baku.SearchHumans(search)[i].ShowInfo(); 
                        } 
                    }
                    else 
                    { 
                        Console.WriteLine("Düzgün seçim edin!"); 
                    } 
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bilinmədik bir xəta baş verdi!");
                }
            } while (opt != "0");
        }
    }
}