using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        //Bir entity service'i kendi entitysi dışında hiçbir entity'nin DAL'ını enjekte etmemelidir.
        private readonly IBrandDal _brandDal;

        private readonly BrandBusinessRules _brandBusinessRules;
        private IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _brandDal = brandDal;//new InMemoryDal(); // başka katmanların classları newlenmez. bu yüzden dependency injection 
            _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public AddBrandResponse Add(AddBrandRequest request)
        {
            if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                throw new Exception("Bu endpointi çalıştırmak için giriş yapmak zorundasınız!");
            }

            _brandBusinessRules.CheckIfBrandNameExists(request.Name);
            // Authentication-Authorization


            Brand brandToAdd = _mapper.Map<Brand>(request);   //mapping   
            _brandDal.Add(brandToAdd);

            AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
            return response;
        }



        public DeleteBrandResponse Delete(DeleteBrandRequest request)
        {
            Brand? brandToDelete = _brandDal.Get(predicate: brand => brand.Id == request.Id);
            _brandBusinessRules.CheckIfBrandExists(brandToDelete);
            Brand deletedBrand = _brandDal.Delete(brandToDelete!);
            DeleteBrandResponse response = _mapper.Map<DeleteBrandResponse>(deletedBrand);
            return response;




        }
        public Brand? GetById(int id)
        {
            return _brandDal.Get(i => i.Id == id);
        }



        public GetBrandListResponse GetList(GetBrandListRequest request)
        {

            IList<Brand> brandList = _brandDal.GetList();


            GetBrandListResponse response = _mapper.Map<GetBrandListResponse>(brandList);
            return response;
        }



        public UpdateBrandResponse Update(UpdateBrandRequest request)
        {

            Brand? BrandToUpdate = _brandDal.Get(predicate: brand => brand.Id == request.Id);
            _brandBusinessRules.CheckIfBrandExists(BrandToUpdate);

            BrandToUpdate = _mapper.Map(request, BrandToUpdate);
            Brand updatedBrand = _brandDal.Update(BrandToUpdate!);
            var response = _mapper.Map<UpdateBrandResponse>(updatedBrand);
            return response;
        }

    }
}