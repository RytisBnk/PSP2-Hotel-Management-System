using System;
using System.Collections.Generic;
using EmployeeApi;
namespace EmployeeRepositoryApi
{
    public interface IEmployeeRepository
    {
        IEmployee Add(IEmployee employee);
        IEmployee Remove(IEmployee employee);
        List<IEmployee> Get();
        IEmployee Find(string firstName, string lastName);
    }
}
