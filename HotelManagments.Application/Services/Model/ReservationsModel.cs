using HotelManagements.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagments.Application.Services.Model
{
    public class ReservationsModel
    {
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int GuestCount { get; set; }
        public decimal TotalPrice { get; set; }
        public byte Status { get; set; }
    }
}
