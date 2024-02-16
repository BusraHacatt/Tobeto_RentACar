namespace Business.Responses.Customer
{
    public class UpdateCustomerResponse
    {
        public UpdateCustomerResponse(int ıd, int userId, DateTime updatedAt)
        {
            Id = ıd;
            UserId = userId;
            UpdatedAt = updatedAt;
        }
        public UpdateCustomerResponse()
        {

        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}