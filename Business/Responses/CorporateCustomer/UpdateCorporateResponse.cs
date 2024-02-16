namespace Business.Responses.CorporateCustomer
{
    public class UpdateCorporateResponse
    {
        public UpdateCorporateResponse(int ıd, string companyName, string taxNo, DateTime updatedAt, int customerId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            UpdatedAt = updatedAt;
            CustomerId = customerId;
        }
        public UpdateCorporateResponse()
        {

        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CustomerId { get; set; }
    }
}