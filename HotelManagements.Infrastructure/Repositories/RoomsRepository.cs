using HotelManagements.Entities;
using HotelManagments.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagements.Infrastructure.Repositories
{
    public class RoomsRepository:IRoomsRepository
    {
        private readonly HotelDbContext _hotelDbContext;
        public RoomsRepository(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }

        public async Task<Rooms> GetAsync(int Id)
        {
            var res = _hotelDbContext.Rooms.Where(i => i.Id == Id).FirstOrDefault();
            return res;
        }
        public async Task<List<Rooms>> GetListAsync()
        {
            var res = _hotelDbContext.Rooms.ToList();
            return res;
        }
    }
}
