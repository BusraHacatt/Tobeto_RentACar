using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.CorporateCustomer;
using Business.Request.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CorporateCustomerManager : ICorporateCustomerService
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;
        private readonly CorporateCustomerBusinessRules _corporateCustomerBusinessRules;
        private IMapper _mapper;

        public CorporateCustomerManager(ICorporateCustomerDal corporateCustomerDal, CorporateCustomerBusinessRules corporateCustomerBusinessRules, IMapper mapper)
        {
            _corporateCustomerDal = corporateCustomerDal;
            _corporateCustomerBusinessRules = corporateCustomerBusinessRules;
            _mapper = mapper;
        }

        public AddCorporateResponse Add(AddCorporateRequest request)
        {
            ValidationTool.Validate(new AddCorporateCustomerRequestValidator(), request);
            CorporateCustomer corporateToAdd = _mapper.Map<CorporateCustomer>(request);
            _corporateCustomerDal.Add(corporateToAdd);
            AddCorporateResponse response = _mapper.Map<AddCorporateResponse>(request);
            return response;
        }

        public DeleteCorporateResponse Delete(DeleteCorporateRequest request)
        {
            CorporateCustomer? corporateTodelete = _corporateCustomerDal.Get(predicate: corp => corp.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corporateTodelete);
            CorporateCustomer deletedCorp = _corporateCustomerDal.Delete(corporateTodelete!);
            DeleteCorporateResponse response = _mapper.Map<DeleteCorporateResponse>(request);
            return response;
        }

        public GetCorporateByIdResponse GetById(GetCorporateByIdRequest request)
        {
            CorporateCustomer? corp = _corporateCustomerDal.Get(predicate: corp => corp.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corp);
            GetCorporateByIdResponse response = _mapper.Map<GetCorporateByIdResponse>(request);
            return response;
        }

        public GetCorporateListResponse GetList(GetCorporateListRequest request)
        {
            IList<CorporateCustomer> corpList = _corporateCustomerDal.GetList(
                predicate: corp => (request.FilterByCustomerId == null || corp.CustomerId == request.FilterByCustomerId));
            GetCorporateListResponse response = _mapper.Map<GetCorporateListResponse>(corpList);
            return response;
        }

        public UpdateCorporateResponse Update(UpdateCorporateRequest request)
        {
            CorporateCustomer? corpToUpdate = _corporateCustomerDal.Get(predicate: corp => corp.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corpToUpdate);
            corpToUpdate = _mapper.Map(request, corpToUpdate);
            CorporateCustomer updatedCorp = _corporateCustomerDal.Update(corpToUpdate!);
            var response = _mapper.Map<UpdateCorporateResponse>(updatedCorp);
            return response;
        }
    }
}
