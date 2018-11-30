using System;
using System.Collections.Generic;
using EmployeeApi;

namespace FOTHEmployeeServiceApi
{
    public interface IFOTHService
    {
        IEmployee CreateFOTHEmployee(string firstName, string lastName);
        List<IEmployee> GetFOTHEmployeeList();
        IEmployee AssignRole(string role, IEmployee employee);
    }
}
