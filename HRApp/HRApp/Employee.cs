using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp
{
    public class Employee : IEmployee
    {
        
        private Department _department;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _age;
        private readonly decimal _salary;


        public Employee(Department department, string firstName, string lastName, int age, decimal salary)
        {
            _department = department;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _salary = salary;

        }

        public Department GetDepartment()
        {
            return _department;
        }

        public void SetDepratment(Department department)
        {
            _department = department;
        }

        public string GetFirstName()
        {
            return _firstName;
        }
    }
}
