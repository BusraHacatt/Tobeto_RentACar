using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Fuel;
using Business.Responses.Fuel;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FuelManager : IFuelService
    {
        private readonly IFuelDal _fuelDal;
        private readonly FuelBusinessRules _fuelBusinessRules;
        private IMapper _mapper;
        public FuelManager(IFuelDal fuelDal, FuelBusinessRules fuelBusinessRules, IMapper mapper)
        {
            _fuelDal = fuelDal;
            _fuelBusinessRules = fuelBusinessRules;
            _mapper = mapper;
        }

        public AddFuelResponse Add(AddFuelRequest request)
        {
            _fuelBusinessRules.CheckIfFuelNameExists(request.Name);


            Fuel fuelToAdd = _mapper.Map<Fuel>(request);

            _fuelDal.Add(fuelToAdd);

            AddFuelResponse response = _mapper.Map<AddFuelResponse>(fuelToAdd);
            return response;
        }

        public DeleteFuelResponse Delete(DeleteFuelRequest request)
        {
            //Fuel fuelToDelete = _fuelBusinessRules.FindFuelId(id);
            //fuelToDelete.DeletedAt = DateTime.Now;
            //DeleteFuelResponse response = _mapper.Map<DeleteFuelResponse>(fuelToDelete);
            //return response;
            Fuel? fuelTodelete = _fuelDal.Get(predicate: fuel => fuel.Id == request.Id);
            _fuelBusinessRules.CheckIfFuelExists(fuelTodelete);
            Fuel deletedFuel = _fuelDal.Delete(fuelTodelete!);
            DeleteFuelResponse response = _mapper.Map<DeleteFuelResponse>(deletedFuel);
            return response;
        }


        public GetFuelListResponse GetList(GetFuelListRequest request)
        {
            IList<Fuel> fuelList = _fuelDal.GetList();
            GetFuelListResponse response = _mapper.Map<GetFuelListResponse>(fuelList);
            return response;

        }

        public UpdateFuelResponse Update(UpdateFuelRequest request)
        {
            //Fuel fuelToUpdate = _fuelBusinessRules.FindFuelId(id);
            //fuelToUpdate.Name = request.Name;
            //fuelToUpdate.UpdatedAt = DateTime.Now;

            //UpdateFuelResponse response = _mapper.Map<UpdateFuelResponse>(fuelToUpdate);
            //return response;
            Fuel? fuelToUpdate = _fuelDal.Get(predicate: fuel => fuel.Id == request.Id);
            _fuelBusinessRules.CheckIfFuelExists(fuelToUpdate);

            fuelToUpdate = _mapper.Map(request, fuelToUpdate);
            Fuel updatedFuel = _fuelDal.Update(fuelToUpdate);
            var response = _mapper.Map<UpdateFuelResponse>(updatedFuel);
            return response;



        }
    }
}