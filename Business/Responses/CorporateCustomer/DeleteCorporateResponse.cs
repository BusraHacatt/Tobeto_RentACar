namespace Business.Responses.CorporateCustomer
{
    public class DeleteCorporateResponse
    {
        public DeleteCorporateResponse(int ıd, string companyName, string taxNo, DateTime deletedAt, int customerId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            DeletedAt = deletedAt;
            CustomerId = customerId;
        }
        public DeleteCorporateResponse()
        {

        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public DateTime DeletedAt { get; set; }
        public int CustomerId { get; set; }
    }
}