using System;
using System.Collections.Generic;
using EmployeeApi;
using EmployeeFacadeApi;
using FOTHEmployeeServiceApi;
using ManagementEmployeeServiceApi;

namespace DefaultEmployee
{
    public class DefaultEmployeeFacade : IEmployeeFacade
    {
        private readonly IFOTHService _foth;
        private readonly IManagementService _management;

        public DefaultEmployeeFacade(IFOTHService foth, IManagementService management)
        {
            _foth = foth;
            _management = management;
        }

        public IEmployee CreateFOTHEmployee(string firstName, string lastName)
        {
            var employee = _foth.CreateFOTHEmployee(firstName, lastName);
            return employee;
        }

        public IEmployee CreateManagementEmployee(string firstName, string lastName)
        {
            var employee = _management.CreateManager(firstName, lastName);
            return employee;
        }

        public List<IEmployee> GetAllEmployees()
        {
            var firstList = _foth.GetFOTHEmployeeList();
            var secondList = _management.GetManagers();
            var result = new List<IEmployee>();
            result.AddRange(firstList);
            result.AddRange(secondList);
            return result;
        }

        public List<IEmployee> GetFOTHEmployees()
        {
            var employees = _foth.GetFOTHEmployeeList();
            return employees;
        }

        public List<IEmployee> GetManagementEmployees()
        {
            var employees = _management.GetManagers();
            return employees;
        }
    }
}
