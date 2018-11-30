using System;
using EmployeeApi;

namespace ManagementEmployee
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public EmployeeFactory()
        {
        }

        public IEmployee Create(string firstName, string lastName)
        {
            var employee = new Employee(firstName, lastName)
            {
                Salary = 1000,
                Role = "Organisational management"
            };
            return employee;
        }
    }
}
