namespace Business.Request.CorporateCustomer
{
    public class DeleteCorporateRequest
    {
        public int Id { get; set; }

        public DeleteCorporateRequest(int ıd)
        {
            Id = ıd;
        }
    }
}