using System;
namespace UIApi.Views
{
    public interface IEmployeeView
    {
        void ShowMenu();
        void DisplayManagement();
        void DisplayFOTH();
        void DisplayAllEmployees();
        void CreateNewEmployee();
    }
}
