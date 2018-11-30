using System;
namespace UIApi.Controllers
{
    public interface IEmployeeController
    {
        string CreateManagementEmployee(string firstName, string lastName);
        string CreateFOTHEmployee(string firstName, string lastName);
        string GetManagement();
        string GetFOTH();
        string GetAllEmployees();
    }
}
