using Business.Request.Brand;
using Business.Responses.Brand;

namespace Business.Abstract;

public interface IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request);
    public UpdateBrandResponse Update(UpdateBrandRequest request);
    public DeleteBrandResponse Delete(DeleteBrandRequest request);
    public GetBrandListResponse GetList(GetBrandListRequest request);
}