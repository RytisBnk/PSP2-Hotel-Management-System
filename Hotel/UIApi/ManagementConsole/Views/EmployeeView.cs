using System;
using UIApi.Controllers;
using UIApi.Views;

namespace ManagementConsole.Views
{
	public class EmployeeView : IEmployeeView
    {
        private readonly IEmployeeController _controller;

        public EmployeeView(IEmployeeController controller)
        {
            _controller = controller;
        }

        public void CreateNewEmployee()
        {
            Console.WriteLine("Enter firstName:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter lastName:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Choose type");
            Console.WriteLine("1. FOTH");
            Console.WriteLine("2. Management");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var foth = _controller.CreateFOTHEmployee(firstName, lastName);
                    Console.WriteLine(foth);
                    break;

                case "2":
                    var management = _controller.CreateManagementEmployee(firstName, lastName);
                    Console.WriteLine(management);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();
            ShowMenu();
        }

        public void DisplayAllEmployees()
        {
            var content = _controller.GetAllEmployees();
            Console.WriteLine(content);
            Console.ReadLine();
            ShowMenu();
        }

        public void DisplayFOTH()
        {
            var content = _controller.GetFOTH();
            Console.WriteLine(content);
            Console.ReadLine();
            ShowMenu();
        }

        public void DisplayManagement()
        {
            var content = _controller.GetManagement();
            Console.WriteLine(content);
            Console.ReadLine();
            ShowMenu();
        }

        public void ShowMenu()
        {
            Console.WriteLine("---Employee management menu---");
            Console.WriteLine("1. View all employees");
            Console.WriteLine("2. View FOTH employees");
            Console.WriteLine("3. View management employees");
            Console.WriteLine("4. Create new emoloyee");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DisplayAllEmployees();
                    break;

                case "2":
                    DisplayFOTH();
                    break;

                case "3":
                    DisplayManagement();
                    break;

                case "4":
                    CreateNewEmployee();
                    break;

                case "20":
                    return;


                default:
                    Console.WriteLine("Bad input");
                    ShowMenu();
                    break;
            }
        }
    }
}
