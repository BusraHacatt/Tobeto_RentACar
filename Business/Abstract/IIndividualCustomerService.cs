using Business.Request.IndividualCustomer;
using Business.Responses.IndividualCustomer;

namespace Business.Abstract
{
    public interface IIndividualCustomerService
    {
        public AddIndividualResponse Add(AddIndividualRequest request);
        public UpdateIndividualResponse Update(UpdateIndividualRequest request);
        public DeleteIndividualResponse Delete(DeleteIndividualRequest request);
        public GetIndividualByIdResponse GetById(GetIndividualByIdRequest request);
        public GetIndividualListResponse GetList(GetIndividualListRequest request);
    }
}
