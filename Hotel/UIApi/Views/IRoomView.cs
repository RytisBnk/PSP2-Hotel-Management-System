using System;
namespace UIApi.Views
{
    public interface IRoomView
    {
        void ShowMenu();
        void ShowAllRooms();
        void ShowAvailableRooms();
        void ShowRoomDetails();
        void CreateRoom();

    }
}
