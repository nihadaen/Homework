using System;

namespace Hw1
{
    public class Baku:ICity
    {
        private Human[] _humans = new Human[0];
        public Human[] Humans { get=>_humans ; }
        
        public void AddHuman(Human human)
        {
            Array.Resize(ref _humans, _humans.Length+1);
            _humans[_humans.Length - 1] = human;
        }

        public Human[] GetStudents()
        {
            Human[] std = new Human[0];
            for (int i = 0; i < _humans.Length; i++)
            {
                if (_humans[i] is Student)
                {
                    Array.Resize(ref std, std.Length+1);
                    std[std.Length - 1] = _humans[i];
                }
            }

            if (std.Length == 0)
            {
                Console.WriteLine("Student yoxdur!");
            }
            return std;
        }
        public Human[] GetEmployees()
        {
            Human[] emp = new Human[0];
            for (int i = 0; i < _humans.Length; i++)
            {
                if (_humans[i] is Employee)
                {
                    Array.Resize(ref emp, emp.Length+1);
                    emp[emp.Length - 1] = _humans[i];
                }
            }
            if (emp.Length == 0)
            {
                Console.WriteLine("Employee yoxdur!");
            }
            return emp;
        }

        public Human[] SearchHumans(string search)
        {
            Human[] arr = new Human[0]; 
            for (int i = 0; i < _humans.Length; i++)
            {
                string fullName = (_humans[i].Name + " " + _humans[i].Surname).ToLower();
                if (fullName.Contains(search.ToLower()))
                {
                    Array.Resize(ref arr, arr.Length+1);
                    arr[arr.Length - 1] = _humans[i];
                }
            }

            if (arr.Length == 0)
            {
                Console.WriteLine("Axtarış dəyərinə uyğun insan tapılmadı!");
            }
            return arr;
        }

        public int GetStdCount()
        {
            int count = 0;
            for (int i = 0; i < _humans.Length; i++)
            {
                if (_humans[i] is Student)
                {
                    count++;
                }
            }

            return count;
        }
        public int GetEmpCount()
        {
            int count = 0;
            for (int i = 0; i < _humans.Length; i++)
            {
                if (_humans[i] is Employee)
                {
                    count++;
                }
            }
            return count;
        }
    }
}