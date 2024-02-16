namespace Business.Request.Customer
{
    public class UpdateCustomerRequest
    {
        public UpdateCustomerRequest(int ıd, int userId)
        {
            Id = ıd;
            UserId = userId;
        }

        public int Id { get; set; }
        public int UserId { get; set; }

    }
}
