using System;
using UIApi.Controllers;
using UIApi.Views;

namespace ManagementConsole.Views
{
    public class ReservationView : IReservationView
    {
        private readonly IReservationController _controller;

        public ReservationView(IReservationController controller)
        {
            _controller = controller;
        }

        public void CancelReservation()
        {
            Console.WriteLine("Enter roomNumber, startDAte, endDate: ");
            var number = int.Parse(Console.ReadLine());
            var start = Console.ReadLine();
            var end = Console.ReadLine();

            var result = _controller.CancelReservation(number, start, end);
            Console.WriteLine(result);
        }

        public void CreateReservation()
        {
            Console.WriteLine("Enter room number");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter start date");
            var start = Console.ReadLine();
            Console.WriteLine("Enter end date");
            var end = Console.ReadLine();
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            var lastname = Console.ReadLine();
            Console.WriteLine("Enter email");
            var email = Console.ReadLine();

            var content = _controller.CreateReservation(number, start, end, name, lastname, email);
            Console.WriteLine(content);
        }

        public void DisplayReservations()
        {
            Console.WriteLine("Enter start date: ");
            var startDate = Console.ReadLine();
            Console.WriteLine("Enter end date: ");
            var endDate = Console.ReadLine();
            var content = _controller.GetReservations(startDate, endDate);
            Console.WriteLine(content);
            Console.ReadLine();
            ShowMenu();
        }

        public void DisplayRoomReservations()
        {
            Console.WriteLine("Enter room number:");
            var number = int.Parse(Console.ReadLine());
            var content = _controller.GetRoomReservations(number);
            Console.WriteLine(content);
            Console.ReadLine();
            ShowMenu();
        }

        public void ShowMenu()
        {
            Console.WriteLine("---Reservation management menu---");
            Console.WriteLine("1. View all reservations");
            Console.WriteLine("2. View specific room reservations");
            Console.WriteLine("3. Create new reservation");
            Console.WriteLine("4. Cancel reservation");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DisplayReservations();
                    break;

                case "2":
                    DisplayRoomReservations();
                    break;

                case "3":
                    CreateReservation();
                    break;

                case "4":
                    CancelReservation();
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
