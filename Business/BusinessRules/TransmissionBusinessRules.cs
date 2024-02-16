using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class TransmissionBusinessRules
    {
        private readonly ITransmissionDal _transmissionDal;
        public TransmissionBusinessRules(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }
        public void CheckIfNameTransmissionNameExists(string tName)
        {
            bool isExists = _transmissionDal.GetList().Any(x => x.Name == tName);
            if (isExists)
            {
                throw new Exception("Transmission already exists.");
            }
        }
        public Transmission FindTransmissionId(int id)
        {
            Transmission transmission = _transmissionDal.GetList().SingleOrDefault(b => b.Id == id);
            return transmission;
        }
        public void CheckIfTransmissionExists(Transmission? transmission)
        {
            if (transmission is null)
                throw new NotFoundException("Transmission not found.");
        }

    }
}