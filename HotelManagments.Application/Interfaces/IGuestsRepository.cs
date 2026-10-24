using HotelManagements.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagments.Application.Interfaces
{
    public interface IGuestsRepository
    {
        Task AddAsync(Guests guests);
        Task<Guests> GetAsync(int Id);
        Task<List<Guests>> GetListAsync();

    }
}
