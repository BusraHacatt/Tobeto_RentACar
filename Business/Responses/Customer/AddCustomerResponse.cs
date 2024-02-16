namespace Business.Responses.Customer
{
    public class AddCustomerResponse
    {
        public AddCustomerResponse(int ıd, int userId, DateTime createdAt)
        {
            Id = ıd;
            UserId = userId;
            CreatedAt = createdAt;
        }
        public AddCustomerResponse()
        {

        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}