using System;
using System.Collections.Generic;
using EmployeeApi;
using EmployeeRepositoryApi;
using FOTHEmployeeServiceApi;
using System.Linq;
using Autofac.Features.AttributeFilters;

namespace RegularFOTH
{
    public class RegularFOTHService : IFOTHService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IEmployeeFactory _factory;

        public RegularFOTHService(IEmployeeRepository repository, [KeyFilter("foth")] IEmployeeFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public IEmployee AssignRole(string role, IEmployee employee)
        {
            employee.Role = role;
            return employee;
        }

        public IEmployee CreateFOTHEmployee(string firstName, string lastName)
        {
            var employee = _factory.Create(firstName, lastName);
            _repository.Add(employee);
            return employee;
        }

        public List<IEmployee> GetFOTHEmployeeList()
        {
            var result = _repository.Get().Where(emp => emp.Salary > 0).ToList();
            return result;
        }
    }
}
