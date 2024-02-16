using Core.Entities;

namespace Entities.Concrete
{
    public class CorporateCustomer : Entity<int>
    {
        public CorporateCustomer(string companyName, string taxNo, int customerId)
        {
            CompanyName = companyName;
            TaxNo = taxNo;
            CustomerId = customerId;
        }
        public CorporateCustomer()
        {

        }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public Customer? Customer { get; set; } = null;
    }
}