using System;
using UIApi.Controllers;
using UIApi.Views;

namespace ManagementConsole.Views
{
    public class RoomView : IRoomView
    {
        private readonly IRoomController _controller;

        public RoomView(IRoomController controller)
        {
            _controller = controller;
        }

        public void CreateRoom()
        {
            Console.WriteLine("Enter room number:");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price:");
            var price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter capacity:");
            var capacity = int.Parse(Console.ReadLine());
            var createdRoom = _controller.RegisterNewRoom(number, price, capacity);
            Console.WriteLine("Created: ");
            Console.WriteLine(createdRoom);
            ShowMenu();
        }

        public void ShowAllRooms()
        {
            var content = _controller.GetAllRooms();
            Console.WriteLine(content);
            ShowMenu();
        }

        public void ShowAvailableRooms()
        {
            Console.WriteLine("Enter startDate");
            var startDate = Console.ReadLine();
            Console.WriteLine("Enter endDate");
            var endDate = Console.ReadLine();
            var content = _controller.GetAvailableRooms(startDate, endDate);
            Console.WriteLine(content);
            ShowMenu();
        }

        public void ShowMenu()
        {
            Console.WriteLine("---Room management menu---");
            Console.WriteLine("1. View all rooms");
            Console.WriteLine("2. View available rooms");
            Console.WriteLine("3. Create new room");
            var input = Console.ReadLine();
            switch (input) 
            {
                case "1":
                    ShowAllRooms();
                    break;

                case "2":
                    ShowAvailableRooms();
                    break;

                case "3":
                    CreateRoom();
                    break;

                case "20":
                    return;


                default:
                    Console.WriteLine("Bad input");
                    ShowMenu();
                    break;
            }
        }

        public void ShowRoomDetails()
        {
            throw new NotImplementedException();
        }
    }
}
