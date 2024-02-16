using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.InMemory
{
    public class InMemoryFuelDal : InMemoryEntityRepositoryBase<Fuel, int>, IFuelDal
    {
        protected override int generateId()
        {
            int nextId = Entities.Count == 0 ? 1 : Entities.Max(e => e.Id) + 1;
            return nextId;
        }
    }
}
