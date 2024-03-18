namespace Backend.Endpoints.Customer.Register
{
    /*
        -Id
        -Name 
        -Sex
        -Date of birth
        -Phone
        -E-mail
    <----------------------------------->
        -Subscription
        -Expiration Date
     */
    public class CustomerRegisterReq
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Subscription { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
