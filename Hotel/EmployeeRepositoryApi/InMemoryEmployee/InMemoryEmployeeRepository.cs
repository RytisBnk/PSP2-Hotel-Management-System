using System;
using System.Collections.Generic;
using EmployeeApi;
using EmployeeRepositoryApi;

namespace InMemoryEmployee
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        private readonly List<IEmployee> _employees;

        public InMemoryEmployeeRepository() 
        {
            _employees = new List<IEmployee>();
        }

        public IEmployee Add(IEmployee employee)
        {
            if (_employees.Contains(employee)) 
            {
                throw new ArgumentException("Employee already in repository");
            }
            _employees.Add(employee);
            return employee;
        }

        public IEmployee Find(string firstName, string lastName)
        {
            var result = _employees.Find(emp => emp.FirstName == firstName && emp.LastName == lastName);
            return result;
        }

        public List<IEmployee> Get()
        {
            return _employees;
        }

        public IEmployee Remove(IEmployee employee)
        {
            _employees.Remove(employee);
            return employee;
        }
    }
}
