using System;
using EmployeeApi;

namespace FOTHEmployee
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
                Salary = 400
            };
            return employee;
        }
    }
}
