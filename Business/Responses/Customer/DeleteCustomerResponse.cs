namespace Business.Responses.Customer
{
    public class DeleteCustomerResponse
    {
        public DeleteCustomerResponse(int ıd, int userId, DateTime deletedAt)
        {
            Id = ıd;
            UserId = userId;
            DeletedAt = deletedAt;
        }
        public DeleteCustomerResponse()
        {

        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}