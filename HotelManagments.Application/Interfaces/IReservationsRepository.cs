using HotelManagements.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagments.Application.Interfaces
{
    public interface IReservationsRepository
    {
        Task AddAsync(Reservations guests);
        Task<Reservations> GetAsync(int Id);
        Task<List<Reservations>> GetListAsync();
        Task<List<Reservations>> GetListAsync(int? roomId, DateTime? startDate, DateTime? endDate);
    }
}
