namespace Backend.Endpoints.Customer.Put
{
    public class CustomerPutReq
    {
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
