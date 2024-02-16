using Core.CrossCuttingConcerns.Exceptions;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class IndividualCustomerBusinessRules
    {
        public void CheckIfIndividualExists(IndividualCustomer? individualCustomer)
        {
            if (individualCustomer is null)
                throw new NotFoundException("IndividualCustomer not found.");
        }
    }
}