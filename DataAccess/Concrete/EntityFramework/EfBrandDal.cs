using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public Brand Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Delete(Brand entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Brand? Get(Func<Brand, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Brand> GetList(Func<Brand, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Brand Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
