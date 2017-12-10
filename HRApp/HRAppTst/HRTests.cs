using System;
using HRApp;
using NUnit.Framework;

namespace HRAppTest
{
    [TestFixture]
    public class HRTests
    {
        //tutaj dodajemy zmienne, które wykorzystujemy bardzo czesto
        private string _expectedCompanyName;
        private Company _company;
        private Employee _employee;


        [SetUp] // jest odpalany przed kaædym testem - kaædy test to nowe Company 
        public void Init()
        {
            _expectedCompanyName = "testName";
            _company = new Company(_expectedCompanyName);
            _employee = new Employee(Department.HumanResources, string.Empty, string.Empty, 0, 0 );
            
        }

        [Test]
        public void Should_CreateCompany_WhenNameIsSpecified()
        { 
            Assert.AreEqual(_expectedCompanyName, _company.GetCompanyName());
        }


        [Test]
        public void Should_AddEmployeeWithDepartment_WhenFieldsAreSpecified()
        {
            Assert.AreEqual(0, _company.GetAllEmployees(Department.HumanResources).Count); 
            _company.AddEmployee(_employee); 
            Assert.AreEqual(1, _company.GetAllEmployees(Department.HumanResources).Count); 
        }

        [Test]
        public void Should_ReturnEmployee_WhenFullNameIsSpecified()
        {
            _company.AddEmployee(_employee);
            var employee = _company.GetEmployeeByName(_employee.FirstName, _employee.LastName);
            Assert.AreEqual(_employee, employee);
        }

        [Test]
        public void Should_IncreaseSalary_WhenPercentageIsSpecified()
        {
            var originalSalary = _employee.Salary; // przechowujemy oryginalne Salary 
            var percentage = 25.0;
            var newSalary = originalSalary *(decimal)(100 + percentage) / 100;
            
            _employee.IncreaseSalary(percentage); //odpalamy metodę z podanym procentem 
            Assert.AreEqual(_employee.Salary, newSalary);
        }
    }
}
