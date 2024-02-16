using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.IndividualCustomer;
using Business.Request.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class IndividualCustomerManager : IIndividualCustomerService
    {
        private readonly IIndividualCustomerDal _ındividualCustomerDal;
        private readonly IndividualCustomerBusinessRules _businessRules;
        private IMapper _mapper;

        public IndividualCustomerManager(IIndividualCustomerDal ındividualCustomerDal, IndividualCustomerBusinessRules businessRules, IMapper mapper)
        {
            _ındividualCustomerDal = ındividualCustomerDal;
            _businessRules = businessRules;
            _mapper = mapper;
        }

        public AddIndividualResponse Add(AddIndividualRequest request)
        {
            ValidationTool.Validate(new AddIndividualRequestValidator(), request);

            IndividualCustomer indivToAdd = _mapper.Map<IndividualCustomer>(request);
            _ındividualCustomerDal.Add(indivToAdd);
            AddIndividualResponse response = _mapper.Map<AddIndividualResponse>(indivToAdd);
            return response;
        }

        public DeleteIndividualResponse Delete(DeleteIndividualRequest request)
        {
            IndividualCustomer? indivToDelete = _ındividualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _businessRules.CheckIfIndividualExists(indivToDelete);
            IndividualCustomer deletedIndiv = _ındividualCustomerDal.Delete(indivToDelete!);
            DeleteIndividualResponse response = _mapper.Map<DeleteIndividualResponse>(deletedIndiv);
            return response;

        }

        public GetIndividualByIdResponse GetById(GetIndividualByIdRequest request)
        {
            IndividualCustomer? indiv = _ındividualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _businessRules.CheckIfIndividualExists(indiv);
            GetIndividualByIdResponse response = _mapper.Map<GetIndividualByIdResponse>(indiv);
            return response;
        }

        public GetIndividualListResponse GetList(GetIndividualListRequest request)
        {
            IList<IndividualCustomer> indivList = _ındividualCustomerDal.GetList(
                predicate: indiv => (request.FilterByCustomerId == null || indiv.CustomerId == request.FilterByCustomerId));


            GetIndividualListResponse response = _mapper.Map<GetIndividualListResponse>(indivList);
            return response;
        }

        public UpdateIndividualResponse Update(UpdateIndividualRequest request)
        {
            IndividualCustomer? indivToUpdate = _ındividualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _businessRules.CheckIfIndividualExists(indivToUpdate);

            indivToUpdate = _mapper.Map(request, indivToUpdate);
            IndividualCustomer updatedIndiv = _ındividualCustomerDal.Update(indivToUpdate!);
            var response = _mapper.Map<UpdateIndividualResponse>(updatedIndiv);
            return response;
        }
    }
}