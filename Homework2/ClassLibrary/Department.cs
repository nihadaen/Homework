using System;

namespace ClassLibrary
{
    public class Department
    {
        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit = 250;
        private Employee[] _employees = new Employee[0];

        public Department(int employeeLimit)
        {
            EmployeeLimit = employeeLimit;
        }

        public Employee[] Employees
        {
            get => _employees;
        }
        
        public void AddEmployee(Employee employee){
            if (_employees.Length < EmployeeLimit)
            { 
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
            }
        }
    }
}