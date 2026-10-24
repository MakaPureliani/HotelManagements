using HotelManagements.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagments.Application.Interfaces
{
    public interface IRoomsRepository
    {
        Task<Rooms> GetAsync(int Id);
        Task<List<Rooms>> GetListAsync();
    }
}
