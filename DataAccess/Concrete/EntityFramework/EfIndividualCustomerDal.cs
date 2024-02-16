using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIndividualCustomerDal : IIndividualCustomerDal
    {
        private readonly RentACarContext _context;

        public EfIndividualCustomerDal(RentACarContext context)
        {
            _context = context;
        }

        public IndividualCustomer Add(IndividualCustomer entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            _context.Entry(entity).State = EntityState.Added;
            _context.IndividualCustomers.Add(entity);
            return entity;
        }

        public IndividualCustomer Delete(IndividualCustomer entity, bool isSoftDelete = true)
        {
            entity.DeletedAt = DateTime.UtcNow;
            if (!isSoftDelete)
            {
                _context.IndividualCustomers.Remove(entity);
            }
            _context.SaveChanges();
            return entity;
        }

        public IndividualCustomer? Get(Func<IndividualCustomer, bool> predicate)
        {
            IndividualCustomer? ındividualCustomer = _context.IndividualCustomers.FirstOrDefault(predicate);
            return ındividualCustomer;
        }

        public IList<IndividualCustomer> GetList(Func<IndividualCustomer, bool>? predicate = null)
        {
            IQueryable<IndividualCustomer> query = _context.Set<IndividualCustomer>();
            if (predicate != null)
            {
                query = query.Where(predicate).AsQueryable();
            }
            return query.ToList();
        }

        public IndividualCustomer Update(IndividualCustomer entity)
        {
            entity.DeletedAt = DateTime.UtcNow;
            _context.IndividualCustomers.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
