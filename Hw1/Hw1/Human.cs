using System;

namespace Hw1
{
    public class Human
    {
        private string _name;
        private string _surname;
        public int Age;
        
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name
        {
            get => _name;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsLetter(value[i]))
                    {
                        _name = null;
                        break;
                    }
                }

                _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsLetter(value[i]))
                    {
                        _surname = null;
                        break;
                    }
                }

                _surname = value;

            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"FullName: {Name} {Surname} - Age: {Age}");
        }
    }
}