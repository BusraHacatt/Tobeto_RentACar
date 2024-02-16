using Business.Request.Model;
using Business.Responses.Model;

namespace Business.Abstract
{
    public interface IModelService
    {
        public AddModelResponse Add(AddModelRequest request);
        public UpdateModelResponse Update(UpdateModelRequest request);
        public DeleteModelResponse Delete(DeleteModelRequest request);
        public GetModelListResponse GetList(GetModelListRequest request);
        public GetModelByIdResponse GetById(GetModelByIdRequest request);
    }
}