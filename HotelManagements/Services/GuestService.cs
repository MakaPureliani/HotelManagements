using HotelManagements.Entities;
using HotelManagements.Interfaces;
using HotelManagements.Model;

namespace HotelManagements.Services
{
    public class GuestService : IGuestService
    {
        private readonly HotelDbContext _context;
        public GuestService(HotelDbContext context)
        {
            _context = context;
        }
        public void AddGuest(AddGuestRequest request)
        {
            var guest = new Guests
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
            };
            _context.Add(guest);
            _context.SaveChanges();
        }

        public GuestModel GetGuest(int id)
        {
            if (!_context.Guests.Any(i => i.Id == id))
            {
                throw new Exception("Incorrect data");
            }
            return _context.Guests.Where(i => i.Id == id).Select(i => new GuestModel
            {
                Email = i.Email,
                FirstName = i.FirstName,
                Id = i.Id,
                LastName = i.LastName,
                PhoneNumber = i.PhoneNumber,


            }).First();
        }

        public List<GuestModel> GetGuests()
        {
            return _context.Guests.Select(i => new GuestModel
            {
                Email = i.Email,
                FirstName = i.FirstName,
                Id = i.Id,
                LastName = i.LastName,
                PhoneNumber = i.PhoneNumber,


            }).ToList();
        }
    }
}
