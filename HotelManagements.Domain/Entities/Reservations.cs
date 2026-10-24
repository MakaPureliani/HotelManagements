namespace HotelManagements.Entities
{
    public class Reservations
    {
        public int Id { get; set; } 
        public Guests Guests { get; set; }
        public Rooms Rooms { get; set; }
        public DateTime CheckInDate { get; set;  }
        public DateTime CheckOutDate { get; set; }
        public int GuestCount { get; set; }
        public decimal TotalPrice { get; set; }
        public byte Status { get; set; }
    }
}

