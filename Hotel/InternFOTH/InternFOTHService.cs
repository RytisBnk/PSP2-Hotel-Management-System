using System;
using System.Collections.Generic;
using EmployeeApi;
using EmployeeRepositoryApi;
using FOTHEmployeeServiceApi;
using System.Linq;
using Autofac.Features.AttributeFilters;

namespace InternFOTH
{
    public class InternFOTHService : IFOTHService
    {
        private readonly IEmployeeFactory _factory;
        private readonly IEmployeeRepository _repository;

        public InternFOTHService([KeyFilter("foth")] IEmployeeFactory factory, IEmployeeRepository repository)
        {
            _factory = factory;
            _repository = repository;
        }

        public IEmployee AssignRole(string role, IEmployee employee)
        {
            employee.Role = role;
            return employee;
        }

        public IEmployee CreateFOTHEmployee(string firstName, string lastName)
        {
            var employee = _factory.Create(firstName, lastName);
            employee.Role = "Intern";
            employee.Salary = 0;
            return employee;
        }

        public List<IEmployee> GetFOTHEmployeeList()
        {
            var result = _repository.Get().Where(emp => !(emp.Salary > 0)).ToList();
            return result;
        }
    }
}
