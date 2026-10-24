using HotelManagements.Entities;
using HotelManagments.Application.Interfaces;
using HotelManagments.Application.Services.Model;

namespace HotelManagements.Services
{
    public class GuestService
    {
        private readonly IGuestsRepository _customerContext;
        public GuestService(IGuestsRepository customerContext)
        {
            _customerContext = customerContext;
        }
        public void AddGuest(AddGuestRequest request)
        {
            _customerContext.AddAsync(
                new Guests
                {
                    Email = request.Email,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    PhoneNumber = request.PhoneNumber
                });
        }

        public async Task<GuestModel> GetGuest(int id)
        {
            var result = await _customerContext.GetAsync(id);
            return new GuestModel
            {
                PhoneNumber = result.PhoneNumber,
                Email = result.Email,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Id = result.Id
            };
        }

        public async Task<List<GuestModel>> GetGuests()
        {
            var result = await _customerContext.GetListAsync();
            return result.Select(i => new GuestModel
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
