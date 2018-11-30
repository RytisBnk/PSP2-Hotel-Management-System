using System;
using System.Collections.Generic;
using EmployeeApi;

namespace ManagementEmployeeServiceApi
{
    public interface IManagementService
    {
        IEmployee CreateManager(string firstName, string lastName);
        List<IEmployee> GetManagers();
    }
}
