using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTransmissionDal : ITransmissionDal
    {
        public Transmission Add(Transmission entity)
        {
            throw new NotImplementedException();
        }

        public Transmission Delete(Transmission entity)
        {
            throw new NotImplementedException();
        }

        public Transmission Delete(Transmission entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Transmission? Get(Func<Transmission, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Transmission> GetList(Func<Transmission, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Transmission Update(Transmission entity)
        {
            throw new NotImplementedException();
        }
    }
}