using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFuelDal : IFuelDal
    {
        public Fuel Add(Fuel entity)
        {
            throw new NotImplementedException();
        }

        public Fuel Delete(Fuel entity, bool isSoftDelete)
        {
            throw new NotImplementedException();
        }

        public Fuel? Get(Func<Fuel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Fuel> GetList(Func<Fuel, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Fuel Update(Fuel entity)
        {
            throw new NotImplementedException();
        }
    }
}

