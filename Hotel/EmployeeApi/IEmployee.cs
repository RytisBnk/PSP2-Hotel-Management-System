using System;
namespace EmployeeApi
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        double Salary { get; set; }
        string Role { get; set; }
    }
}
