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
        private List<IEmployee> _employees;

        public Company(string name)
        {
            _name = name;
            _employees = new List<IEmployee>();
        }

        public string GetName() //publiczna metoda, uruchamiana w testach  
        {
            return _name;
        }

        public void AddEmployee(IEmployee employee)
        {
            
            _employees.Add(employee);
        }

        public List<IEmployee> GetAllEmployees()
        {
            return _employees;
        }


        public List<IEmployee> GetAllEmployees(Department department)
        {
            return _employees.Where(x => x.GetDepartment() == department).ToList();
        }
    }
}
