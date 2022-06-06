using System;

namespace Homework
{
    public class Student
    {
        public int _no;
        private string _fullName;
        private string _groupNo;
        public static int Index;

        public Student()
        {
            Index++;
            _no = Index;
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
            }
        }

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (check(value))
                {
                    _groupNo = value;
                }
            }
        }

        public bool check(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (Char.IsLetter(str[0]) && Char.IsDigit(str[i]))
                {
                    return true;
                }
            }

            return false;
        }
        
    }
}