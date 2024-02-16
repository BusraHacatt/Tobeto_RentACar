using Business.Request.Car;
using Business.Responses.Car;

namespace Business.Abstract
{
    public interface ICarService
    {
        public AddCarResponse Add(AddCarRequest request);
        public UpdateCarResponse Update(UpdateCarRequest request);
        public DeleteCarResponse Delete(DeleteCarRequest request);
        public GetCarListResponse GetList(GetCarListRequest request);
    }
}