using Business.Request.Transmission;
using Business.Responses.Transmission;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public AddTransmissionResponse Add(AddTransmissionRequest request);
        public UpdateTransmissionResponse Update(UpdateTransmissionRequest request);
        public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request);
        public GetTransmissionListResponse GetList(GetTransmissionListRequest request);

    }
}