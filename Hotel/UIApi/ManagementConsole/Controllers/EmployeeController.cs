using System;
using System.Collections.Generic;
using System.Text;
using EmployeeApi;
using EmployeeFacadeApi;
using UIApi.Controllers;

namespace ManagementConsole.Controllers
{
    public class EmployeeController : IEmployeeController
    {
        private readonly IEmployeeFacade _facade;

        public EmployeeController(IEmployeeFacade facade)
        {
            _facade = facade;
        }

        public string CreateFOTHEmployee(string firstName, string lastName)
        {
            var result = _facade.CreateFOTHEmployee(firstName, lastName);

            return ConvertObject(result);
        }

        public string CreateManagementEmployee(string firstName, string lastName)
        {
            var result = _facade.CreateManagementEmployee(firstName, lastName);

            return ConvertObject(result);
        }

        public string GetAllEmployees()
        {
            var result = _facade.GetAllEmployees();

            return ConvertList(result);
        }

        public string GetFOTH()
        {
            var result = _facade.GetFOTHEmployees();

            return ConvertList(result);
        }

        public string GetManagement()
        {
            var result = _facade.GetManagementEmployees();

            return ConvertList(result);
        }

        private string ConvertObject(IEmployee employee)
        {
            return "Name: " + employee.FirstName + " " + employee.LastName + " || "
                                      + "Salary: " + employee.Salary + " || "
                                      + "Role" + employee.Role + "\n";
        }

        private string ConvertList(List<IEmployee> employees)
        {
            var builder = new StringBuilder();
            foreach (var employee in employees)
            {
                builder.Append(ConvertObject(employee));
            }
            return builder.ToString();
        }
    }
}
