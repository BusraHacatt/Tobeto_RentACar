using Core.CrossCuttingConcerns.Exceptions;
using Entities.Concrete;

namespace Business.BusinessRules
{

    public class CorporateCustomerBusinessRules
    {
        public void CheckIfCorporateCustomerExists(CorporateCustomer? corporateCustomer)
        {
            if (corporateCustomer is null)
                throw new NotFoundException("CorporateCustomer not found.");
        }
    }
}