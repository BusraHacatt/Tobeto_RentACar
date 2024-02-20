﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIndividualCustomerDal : EfEntityRepositoryBase<IndividualCustomer, int, RentACarContext>, IIndividualCustomerDal

    {
        public EfIndividualCustomerDal(RentACarContext context) : base(context)
        {
        }
    }
}
