using System;

namespace ClassLibrary
{
    public class Employee

    {
    protected string _name;
    protected string _surname;
    protected int _salary;
    
    public string Name
    {
        get => _name;
        set
        {
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsUpper(value[0]) && Char.IsLetter(value[i]))
                {
                    count++;
                }
            }

            if (count == value.Length)
            {
                _name = value;
            }
        }
    }

    public string Surname
    {
        get => _surname;
        set
        {
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsUpper(value[0]) && Char.IsLetter(value[i]))
                {
                    count++;
                }
            }

            if (count == value.Length)
            {
                _surname = value;
            }
        }
    }

    public int Salary
    {
        get => _salary;
        set
        {
            if (value >= 250)
            {
                _salary = value;
            }
        }
    }
    }
}