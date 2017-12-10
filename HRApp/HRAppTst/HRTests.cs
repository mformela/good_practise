using HRApp;
using Moq;
using NUnit.Framework;

namespace HRAppTest
{
    [TestFixture]
    public class HRTests
    {
        //tutaj dodajemy zmienne, które wykorzystujemy bardzo czesto
        private string _expectedName;
        private Company _company;
        private IEmployee _employee;


        [SetUp] // jest odpalany przed kaædym testem - kaædy test to nowe Company 
        public void Init()
        {
            _expectedName = "testName";
            _company = new Company(_expectedName);
            _employee = new Mock<IEmployee>().Object;
        }

        [Test]
        public void Should_CreateCompany_WhenNameIsSpecified()
        { 
            Assert.AreEqual(_expectedName, _company.GetName());
        }


        [Test]
        public void Should_AddEmployeeWithDepartment_WhenFieldsAreSpecified()
        {
            var employee = new Mock<IEmployee>();
            employee.Setup(x => x.GetDepartment()).Returns(Department.HumanResources);
           


            Assert.AreEqual(0, _company.GetAllEmployees(Department.HumanResources).Count); 
            _company.AddEmployee(_employee); 
            Assert.AreEqual(1, _company.GetAllEmployees(Department.HumanResources).Count); 

        }
    }
}
