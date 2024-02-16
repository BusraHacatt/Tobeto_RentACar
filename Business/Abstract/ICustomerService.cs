using Business.Request.Customer;
using Business.Responses.Customer;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public AddCustomerResponse Add(AddCustomerRequest request);
        public UpdateCustomerResponse Update(UpdateCustomerRequest request);
        public DeleteCustomerResponse Delete(DeleteCustomerRequest request);
        public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request);
        public GetCustomerListResponse GetList(GetCustomerListRequest request);

    }
}
