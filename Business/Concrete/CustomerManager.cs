using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.Customer;
using Business.Request.Customer;
using Business.Responses.Customer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly CustomerBusinessRules _businessRules;
        private IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal, CustomerBusinessRules businessRules, IMapper mapper)
        {
            _customerDal = customerDal;
            _businessRules = businessRules;
            _mapper = mapper;
        }

        public AddCustomerResponse Add(AddCustomerRequest request)
        {
            ValidationTool.Validate(new AddCustomerRequestValidator(), request);
            Customer customerToAdd = _mapper.Map<Customer>(request);
            _customerDal.Add(customerToAdd);
            AddCustomerResponse response = _mapper.Map<AddCustomerResponse>(request);
            return response;
        }

        public DeleteCustomerResponse Delete(DeleteCustomerRequest request)
        {
            Customer? customerToDelete = _customerDal.Get(predicate: customer => customer.Id == request.Id);
            _businessRules.CheckIfCustomerExists(customerToDelete);
            Customer deletedCustomer = _customerDal.Delete(customerToDelete!);
            DeleteCustomerResponse response = _mapper.Map<DeleteCustomerResponse>(deletedCustomer);
            return response;

        }

        public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request)
        {
            Customer? customer = _customerDal.Get(predicate: customer => customer.Id == request.Id);
            _businessRules.CheckIfCustomerExists(customer);
            GetCustomerByIdResponse response = _mapper.Map<GetCustomerByIdResponse>(customer);
            return response;
        }

        public GetCustomerListResponse GetList(GetCustomerListRequest request)
        {
            IList<Customer> customerList = _customerDal.GetList(
                predicate: customer => (request.FilterByUserId == null || customer.UserId == request.FilterByUserId));
            var response = _mapper.Map<GetCustomerListResponse>(customerList);
            return response;
        }

        public UpdateCustomerResponse Update(UpdateCustomerRequest request)
        {
            Customer? customerToUpdate = _customerDal.Get(predicate: customer => customer.Id == request.Id);
            _businessRules.CheckIfCustomerExists(customerToUpdate);

            customerToUpdate = _mapper.Map(request, customerToUpdate);
            Customer updatedCustomer = _customerDal.Update(customerToUpdate!);
            var response = _mapper.Map<UpdateCustomerResponse>(updatedCustomer);
            return response;
        }
    }
}
