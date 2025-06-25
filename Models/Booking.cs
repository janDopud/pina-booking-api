namespace PinaBookingApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string? CustomerPhoneNumber { get; set; }
        public DateTime StartTime { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;
    }
}