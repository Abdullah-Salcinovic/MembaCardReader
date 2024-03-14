namespace Backend.Endpoints.Customer.GetAll
{
    public class CustomerGetAllRes
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }

    public class CustomerGetAllList
    { 
        public List<CustomerGetAllRes> Customers { get; set; }
    }
}
