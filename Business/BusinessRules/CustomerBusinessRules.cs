using Core.CrossCuttingConcerns.Exceptions;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class CustomerBusinessRules
    {
        public void CheckIfCustomerExists(Customer? customer)
        {
            if (customer is null)
                throw new NotFoundException("Customer not found.");
        }
    }
}