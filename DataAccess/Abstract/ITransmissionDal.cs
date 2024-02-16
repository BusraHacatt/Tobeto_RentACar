using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ITransmissionDal : IEntityRepository<Transmission, int>
    {
    }
}
