using HotelManagements.Entities;

namespace HotelManagements.Interfaces
{
    public interface IRoomService
    {
        List<Rooms> GetRooms();
        Rooms GetRoom(int roomId);

    }
}
