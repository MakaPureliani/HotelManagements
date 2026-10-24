using HotelManagements.Entities;
using HotelManagments.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagements.Infrastructure.Repositories
{
    public class GuestsRepository: IGuestsRepository
    {
        private readonly HotelDbContext _hotelDbContext;
        public GuestsRepository(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }

        public async Task AddAsync(Guests guests)
        {
            await _hotelDbContext.Guests.AddAsync(guests);
            await _hotelDbContext.SaveChangesAsync();

        }
        public async Task<Guests> GetAsync(int Id)
        {
           var res =  _hotelDbContext.Guests.Where(i=> i.Id==Id).FirstOrDefault();
            return res;
        }
        public async Task<List<Guests>> GetListAsync()
        {
            var res = _hotelDbContext.Guests.ToList();
            return res;
        }
    }
}
