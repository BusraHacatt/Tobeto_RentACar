using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : Entity<int>
    {
        public Customer(int userId)
        {
            UserId = userId;
        }
        public Customer()
        {

        }

        public int UserId { get; set; }
        public User? User { get; set; } = null;
        public IndividualCustomer? IndividualCustomers { get; set; } = null;
        public CorporateCustomer? CorporateCustomers { get; set; } = null;

    }
}
