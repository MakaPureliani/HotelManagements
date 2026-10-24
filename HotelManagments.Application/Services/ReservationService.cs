using HotelManagements.Entities;
using HotelManagments.Application.Interfaces;
using HotelManagments.Application.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagments.Application.Services
{
    public class ReservationService
    {
        private readonly IRoomsRepository _roomsRepository;
        private readonly IGuestsRepository _guestsRepository;
        private readonly IReservationsRepository _reservationsRepository;
        public ReservationService(IReservationsRepository reservationsRepository, IGuestsRepository guestsRepository,
                                  IRoomsRepository roomsRepository)
        {
            _roomsRepository = roomsRepository;
            _guestsRepository = guestsRepository;
            _reservationsRepository = reservationsRepository;
        }

        public async Task AddReservation(ReservationsModel request)
        {
            var isActiveRoom = await _roomsRepository.GetAsync(request.RoomId);
            if (isActiveRoom.IsActive == true)
            {
                await _reservationsRepository.AddAsync(new Reservations
                {
                    CheckInDate = request.CheckInDate,
                    CheckOutDate = request.CheckOutDate,
                    GuestCount = request.GuestCount,
                    Status = request.Status,
                    TotalPrice = request.TotalPrice,
                    Rooms = isActiveRoom,
                    Guests = await _guestsRepository.GetAsync(request.GuestId)
                });
            }

        }

    }
}
