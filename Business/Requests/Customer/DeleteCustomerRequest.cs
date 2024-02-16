namespace Business.Request.Customer
{
    public class DeleteCustomerRequest
    {
        public DeleteCustomerRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
