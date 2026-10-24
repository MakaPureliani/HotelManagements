using HotelManagements.Entities;
using HotelManagments.Application.Interfaces;

namespace HotelManagements.Services
{
    public class RoomServices
    {
        private readonly IRoomsRepository _context;
        private readonly IReservationsRepository _reservationsRepository;
        public RoomServices(IRoomsRepository context, IReservationsRepository reservationsRepository)
        {
            _context = context;
            _reservationsRepository = reservationsRepository;

        }

        public async Task<Rooms> GetRoom(int roomId)
        {
            return await _context.GetAsync(roomId);

        }

        public async Task<List<Rooms>> GetRooms(DateTime? startDate, DateTime? endDate)
        {
            var rooms = await _context.GetListAsync();
            rooms.ForEach(i =>
            {
                var reservations = _reservationsRepository.GetListAsync(i.Id, startDate, endDate);
                if (reservations != null)
                {
                    i.IsActive = false;
                }
            }
            );

            return rooms;
        }
    }
}
