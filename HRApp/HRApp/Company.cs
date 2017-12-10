using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp
{

    public enum Department
    {
        HumanResources,
        Sales,
        IT,
        Logistics,
        Accounting
    }


    public class Company
    {
        private readonly string _name;
        private readonly List<Employee> _employees;

        public Company(string name)
        {
            _name = name;
            _employees = new List<Employee>();
        }

        public string GetCompanyName() //publiczna metoda, uruchamiana w testach  
        {
            return _name;
        }

        public void AddEmployee(Employee employee)
        {
            
            _employees.Add(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }


        public List<Employee> GetAllEmployees(Department department)
        {
            return _employees.Where(x => x.Department == department).ToList();
        }

        public Employee GetEmployeeByName(string firstName, string lastName)
        {
            return _employees.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
        
    }
}
