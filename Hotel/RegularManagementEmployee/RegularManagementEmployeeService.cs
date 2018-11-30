using System;
using System.Collections.Generic;
using Autofac.Features.AttributeFilters;
using EmployeeApi;
using EmployeeRepositoryApi;
using ManagementEmployeeServiceApi;

namespace RegularManagementEmployee
{
    public class RegularManagementEmployeeService : IManagementService
    {
        private readonly IEmployeeFactory _factory;
        private readonly IEmployeeRepository _repository;

        public RegularManagementEmployeeService([KeyFilter("management")] IEmployeeFactory factory, IEmployeeRepository repository)
        {
            _factory = factory;
            _repository = repository;
        }

        public IEmployee CreateManager(string firstName, string lastName)
        {
            var employee = _factory.Create(firstName, lastName);
            var result = _repository.Add(employee);
            return result;
        }

        public List<IEmployee> GetManagers()
        {
            var result = _repository.Get();
            return result;
        }
    }
}
