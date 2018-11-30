using System;
using System.Collections.Generic;
using EmployeeApi;

namespace EmployeeFacadeApi
{
    public interface IEmployeeFacade
    {
        IEmployee CreateManagementEmployee(string firstName, string lastName);
        IEmployee CreateFOTHEmployee(string firstName, string lastName);
        List<IEmployee> GetManagementEmployees();
        List<IEmployee> GetFOTHEmployees();
        List<IEmployee> GetAllEmployees();
    }
}
