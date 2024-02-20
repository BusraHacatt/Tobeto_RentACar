using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCorporateCustomerDal : EfEntityRepositoryBase<CorporateCustomer, int, RentACarContext>, ICorporateCustomerDal
    {
        public EfCorporateCustomerDal(RentACarContext context) : base(context)
        {
        }
    }
}