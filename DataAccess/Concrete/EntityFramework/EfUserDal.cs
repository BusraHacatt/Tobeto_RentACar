using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        private readonly RentACarContext _context;

        public EfUserDal(RentACarContext context)
        {
            _context = context;
        }

        public User Add(User entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            _context.Entry(entity).State = EntityState.Added;
            _context.Users.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public User Delete(User entity, bool isSoftDelete = true)
        {
            entity.DeletedAt = DateTime.UtcNow;
            if (!isSoftDelete)
                _context.Users.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public User? Get(Func<User, bool> predicate)
        {
            User? user = _context.Users.FirstOrDefault(predicate);
            return user;
        }

        public IList<User> GetList(Func<User, bool>? predicate = null)
        {
            IQueryable<User> query = _context.Set<User>();
            if (predicate != null)
            {
                query = query.Where(predicate).AsQueryable();
            }
            return query.ToList();
        }

        public User Update(User entity)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            //_context.Entry(entity).State = EntityState.Modified;  
            _context.Users.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}