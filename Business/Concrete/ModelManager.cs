using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.Model;
using Business.Request.Model;
using Business.Responses.Model;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        private readonly IModelDal _modelDal;
        private readonly ModelBusinessRules _businessRules;
        private IMapper _mapper;

        public ModelManager(IModelDal modelDal, ModelBusinessRules businessRules, IMapper mapper)
        {
            _modelDal = modelDal;
            _businessRules = businessRules;
            _mapper = mapper;
        }

        public AddModelResponse Add(AddModelRequest request)
        {
            //_businessRules.CheckIfModelNameLength(request.Name);
            //_businessRules.CheckIdDailyPriceValid(request.DailyPrice);
            //validdation
            //fluent validation
            //if (request.BrandId == 0)
            //    throw new Exception("Brand Id cannot be 0.");
            //if (request.FuelId == 0)
            //    throw new Exception("Fuel Id cannot be 0.");
            //if (request.TransmissionId == 0)
            //    throw new Exception("Transmission Id cannot be 0.");
            //if(string.IsNullOrWhiteSpace(request.Name))
            //    throw new Exception("Name cannor be empty.");
            //if(request.Year<=0)
            //    throw new Exception("Year must be grater than.");


            //if (request.Name.Length < 2)
            //{
            //    throw new BusinessException("Model name must be at least 2 characters.");
            //}
            //if (request.Name.Length > 50)
            //    throw new Exception("Name cannot be longer than 50 characters.");
            //if (request.DailyPrice <= 0)
            //{
            //    throw new BusinessException("Model daily price must greater than 0.");
            //}

            //AddModelRequestValidator validator = new();
            //validator.ValidateAndThrow(request);
            //ValidationResult result=validator.Validate(request);
            //if (!result.IsValid)
            //{
            //    throw new ValidationException(result.Errors);
            //}
            ValidationTool.Validate(new AddModelRequestValidator(), request);

            _businessRules.CheckIfModelNameExists(request.Name);
            _businessRules.CheckIfModelYearShouldBeInLast20Years(request.Year);
            Model modelToAdd = _mapper.Map<Model>(request);
            _modelDal.Add(modelToAdd);
            AddModelResponse response = _mapper.Map<AddModelResponse>(modelToAdd);
            return response;

        }

        public DeleteModelResponse Delete(DeleteModelRequest request)
        {
            Model? modelTodelete = _modelDal.Get(predicate: model => model.Id == request.Id);
            _businessRules.CheckIfModelExists(modelTodelete);
            Model deletedModel = _modelDal.Delete(modelTodelete!);
            DeleteModelResponse response = _mapper.Map<DeleteModelResponse>(deletedModel);
            return response;

            //Model modelToDelete = _businessRules.FindBrandId(id);

            //modelToDelete.DeletedAt = DateTime.Now;
            //DeleteModelResponse response = _mapper.Map<DeleteModelResponse>(modelToDelete);
            //return response;
        }

        public GetModelByIdResponse GetById(GetModelByIdRequest request)
        {
            Model? model = _modelDal.Get(predicate: model => model.Id == request.Id);
            _businessRules.CheckIfModelExists(model);
            GetModelByIdResponse response = _mapper.Map<GetModelByIdResponse>(model);
            return response;
        }

        public GetModelListResponse GetList(GetModelListRequest request)
        {
            //IList<Model> modelList = _modelDal.GetList();

            //GetModelListResponse response = _mapper.Map<GetModelListResponse>(modelList);
            //return response;
            //bool predicate(Model model)
            //{

            //    return (request.FilterByBrandId == null || model.BrandId == request.FilterByBrandId) && (request.FilterByFuelId == null || model.FuelId == request.FilterByFuelId) && (request.FilterByTransmissionId == null || model.TransmissionId == request.FilterByTransmissionId);


            //}
            //IList<Model> modelList = _modelDal.GetList(predicate);
            IList<Model> modelList = _modelDal.GetList(
            predicate: model =>
                (request.FilterByBrandId == null || model.BrandId == request.FilterByBrandId)
                && (request.FilterByFuelId == null || model.FuelId == request.FilterByFuelId)
                && (
                    request.FilterByTransmissionId == null
                    || model.TransmissionId == request.FilterByTransmissionId
                )
        );
            var response = _mapper.Map<GetModelListResponse>(modelList);
            return response;
        }

        public UpdateModelResponse Update(UpdateModelRequest request)
        {
            Model? modelToUpdate = _modelDal.Get(predicate: model => model.Id == request.Id);
            _businessRules.CheckIfModelExists(modelToUpdate);
            //modelToUpdate=_mapper.Map<Model>(request); //Çünkü bizim için yeni bir nesne (referans) oluşturuyor.
            //Ve ayrıca entity sınıfınsa olup da request sınıfında olmayan alanlar(örn. CreatedAt vb.) varsayılan değerler alacak.
            //böylece yanlış bir veri güncellemesi yapmış oluruz.

            modelToUpdate = _mapper.Map(request, modelToUpdate);
            Model updatedModel = _modelDal.Update(modelToUpdate!);
            var response = _mapper.Map<UpdateModelResponse>(updatedModel);
            return response;
            //_businessRules.CheckIfModelNameLength(request.Name);
            //if (request.Name.Length < 2)
            //{
            //    throw new BusinessException("Model name must be at least 2 characters.");
            //}
            //_businessRules.CheckIdDailyPriceValid(request.DailyPrice);
            //if (request.DailyPrice <= 0)
            //{
            //    throw new BusinessException("Model daily price must greater than 0.");
            //}
            //Model modelToUpdate = _businessRules.FindBrandId(id);
            //modelToUpdate.UpdatedAt = DateTime.Now;
            //modelToUpdate.BrandId = request.BrandId;
            //modelToUpdate.TransmissionId = request.TransmissionId;
            //modelToUpdate.DailyPrice = request.DailyPrice;
            //modelToUpdate.FuelId = request.FuelId;
            //modelToUpdate.Name = request.Name;

            //UpdateModelResponse response = _mapper.Map<UpdateModelResponse>(modelToUpdate);
            //return response;
        }
    }
}