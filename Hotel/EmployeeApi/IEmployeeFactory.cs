using System;
namespace EmployeeApi
{
    public interface IEmployeeFactory
    {
        IEmployee Create(string firstName, string lastName);
    }
}
