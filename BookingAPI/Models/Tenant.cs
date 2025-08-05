namespace BookingAPI.Models
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
