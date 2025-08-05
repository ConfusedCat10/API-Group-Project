

namespace BookingAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime BookingDate { get; set; }
        public string Details { get; set; }

        public int? RoomId { get; set; }
        public Room? RoomNumber { get; set; }

    }
}
