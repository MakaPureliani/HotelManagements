using HotelManagements.Entities;
using HotelManagements.Interfaces;

namespace HotelManagements.Services
{
    public class RoomServices : IRoomService
    {
        private readonly HotelDbContext _context;
        public RoomServices(HotelDbContext context)
        {
            _context = context;
        }

        public Rooms GetRoom(int roomId)
        {            
            if (!_context.Rooms.Any(i => i.RoomNumber == roomId && i.IsActive==true))
            {
                throw new Exception("Incorrect roomNumber");
            }
            var room = _context.Rooms.Where(i => i.RoomNumber == roomId).First();
            return room;
        }

        public List<Rooms> GetRooms()
        {
            var result = _context.Rooms.ToList();
            return result;
        }
    }
}
