using Core.Entities;

namespace Entities.Concrete
{
    public class IndividualCustomer : Entity<int>
    {
        public IndividualCustomer(string firstName, string lastName, string nationalIdentity, int customerId)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            CustomerId = customerId;
        }
        public IndividualCustomer()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } = null;
    }
}