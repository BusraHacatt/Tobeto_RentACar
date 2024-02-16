using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Car;
using Business.Responses.Car;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        private readonly CarBusinessRules _carBusinessRules;
        private IMapper _mapper;

        public CarManager(ICarDal carDal, CarBusinessRules carBusinessRules, IMapper mapper)
        {
            _carDal = carDal;
            _carBusinessRules = carBusinessRules;
            _mapper = mapper;
        }

        public AddCarResponse Add(AddCarRequest request)
        {
            //_carBusinessRules.CheckIfCarModelYearsValid(request.ModelYear);
            //int currentYear = DateTime.Now.Year;
            //if (request.ModelYear < currentYear - 20)
            //{
            //    throw new BusinessException("Car model year must be within the last 20 years and not exceed the current year.");
            //}

            Car carToAdd = _mapper.Map<Car>(request);
            _carDal.Add(carToAdd);
            AddCarResponse response = _mapper.Map<AddCarResponse>(carToAdd);
            return response;
        }

        public GetCarListResponse GetList(GetCarListRequest request)
        {
            IList<Car> carList = _carDal.GetList();
            GetCarListResponse response = _mapper.Map<GetCarListResponse>(carList);
            return response;
        }

        public UpdateCarResponse Update(UpdateCarRequest request)
        {
            //_carBusinessRules.CheckIfCarModelYearsValid(request.ModelYear);
            //int currentYear = DateTime.Now.Year;
            //if (request.ModelYear < currentYear - 20)
            //{
            //    throw new BusinessException("Car model year must be within the last 20 years and not exceed the current year.");
            //}
            //Car carToUpdate = _carBusinessRules.FindBrandId(id);


            //UpdateCarResponse response = _mapper.Map<UpdateCarResponse>(carToUpdate);
            //return response;
            Car? carToUpdate = _carDal.Get(predicate: car => car.Id == request.Id);
            _carBusinessRules.CheckIfCarExists(carToUpdate);
            carToUpdate = _mapper.Map(request, carToUpdate);
            Car updatedCar = _carDal.Update(carToUpdate!);
            var response = _mapper.Map<UpdateCarResponse>(updatedCar);
            return response;

        }

        public DeleteCarResponse Delete(DeleteCarRequest request)
        {
            //Car carToDelete = _carBusinessRules.FindBrandId(id);
            //carToDelete.DeletedAt = DateTime.Now;
            //DeleteCarResponse response = _mapper.Map<DeleteCarResponse>(carToDelete);
            //return response;
            Car? carToDelete = _carDal.Get(predicate: car => car.Id == request.Id);
            _carBusinessRules.CheckIfCarExists(carToDelete);
            Car deletedCar = _carDal.Delete(carToDelete);
            var response = _mapper.Map<DeleteCarResponse>(deletedCar);
            return response;

        }
    }
}