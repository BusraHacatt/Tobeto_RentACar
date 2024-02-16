using Business.Request.CorporateCustomer;
using Business.Responses.CorporateCustomer;

namespace Business.Abstract
{
    public interface ICorporateCustomerService
    {
        public AddCorporateResponse Add(AddCorporateRequest request);
        public DeleteCorporateResponse Delete(DeleteCorporateRequest request);
        public UpdateCorporateResponse Update(UpdateCorporateRequest request);
        public GetCorporateByIdResponse GetById(GetCorporateByIdRequest request);
        public GetCorporateListResponse GetList(GetCorporateListRequest request);
    }
}
