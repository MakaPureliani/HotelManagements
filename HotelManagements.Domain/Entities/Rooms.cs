using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagements.Entities
{
    public class Rooms
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public RoomTypes RoomTypeId { get; set; }
        public bool IsActive { get; set; }

        
    }
}
