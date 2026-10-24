using HotelManagements.Entities;
using HotelManagments.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagements.Infrastructure.Repositories
{
    public class ReservationsRepository : IReservationsRepository
    {
        private readonly HotelDbContext _hotelDbContext;
        public ReservationsRepository(HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }

        public async Task AddAsync(Reservations request)
        {
            _hotelDbContext.AddAsync(request);
            _hotelDbContext.SaveChangesAsync();
        }
        public async Task<Reservations> GetAsync(int Id)
        {
            var res = _hotelDbContext.Reservations.Where(i => i.Id == Id).FirstOrDefault();
            return res;
        }
        public async Task<List<Reservations>> GetListAsync(int? roomId, DateTime? startDate, DateTime? endDate)
        {
            var res = new List<Reservations>();
            if (startDate != null && endDate != null)
            {
                res = _hotelDbContext.Reservations.Where(i => i.CheckInDate >= startDate && i.CheckOutDate <= endDate && i.Rooms.Id == roomId).ToList();
            }
            if(roomId !=null)
            {
                res = _hotelDbContext.Reservations.Where(i => i.Rooms.Id == roomId).ToList();
            }
            else
            {
                res = _hotelDbContext.Reservations.ToList();
            }
            return res;
        }

        public Task<List<Reservations>> GetListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
