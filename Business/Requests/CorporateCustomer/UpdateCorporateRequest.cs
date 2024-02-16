namespace Business.Request.CorporateCustomer
{
    public class UpdateCorporateRequest
    {
        public UpdateCorporateRequest(int ıd, string companyName, string taxNo, int customerId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            CustomerId = customerId;
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public int CustomerId { get; set; }
    }
}