namespace Business.Request.Customer
{
    public class AddCustomerRequest
    {
        public AddCustomerRequest(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; set; }

    }
}
