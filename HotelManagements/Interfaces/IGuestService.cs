using HotelManagements.Entities;
using HotelManagements.Model;

namespace HotelManagements.Interfaces
{
    public interface IGuestService
    {
        void AddGuest(AddGuestRequest guest);
        GuestModel GetGuest(int id);    
        List<GuestModel> GetGuests();
    }
}
