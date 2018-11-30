using System;
using Autofac;
using Modules;
using UIApi.Views;

namespace Hotel
{
    class MainClass
    {
        private static IContainer _container;

        public static void Main(string[] args)
        {
            _container = Bootstrapper.Build();

            var roomView = _container.Resolve<IRoomView>();
            var reservationView = _container.Resolve<IReservationView>();
            var employeeView = _container.Resolve<IEmployeeView>();

            ShowInterface(roomView, reservationView, employeeView);
        }

        private static void ShowInterface(IRoomView roomView, IReservationView reservationView, IEmployeeView employeeView)
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("1. Room management");
            Console.WriteLine("2. Reservation management");
            Console.WriteLine("3. Employee management");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    roomView.ShowMenu();
                    break;

                case "2":
                    reservationView.ShowMenu();
                    break;

                case "3":
                    employeeView.ShowMenu();
                    break;

                case "20":
                    return;

                default:
                    break;
            }
            ShowInterface(roomView, reservationView, employeeView);
        }
    }
}
