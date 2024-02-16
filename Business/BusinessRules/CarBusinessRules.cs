using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{


    public class CarBusinessRules
    {
        private readonly ICarDal _carDal;

        public CarBusinessRules(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car FindBrandId(int id)
        {
            Car car = _carDal.GetList().SingleOrDefault(x => x.Id == id);
            return car;
        }
        public void CheckIfCarExists(Car? car)
        {
            if (car is null)
                throw new NotFoundException("Car not found.");
        }


    }
}

