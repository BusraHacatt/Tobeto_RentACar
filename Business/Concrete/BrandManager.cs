using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        private readonly BrandBusinessRules _brandBusinessRules;
        private IMapper _mapper;

        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper)
        {
            _brandDal = brandDal;//new InMemoryDal(); // başka katmanların classları newlenmez. bu yüzden dependency injection 
            _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
        }

        public AddBrandResponse Add(AddBrandRequest request)
        { //İş kuralları
            _brandBusinessRules.CheckIfBrandNameExists(request.Name);

            //validation
            //yetki kontrolü 
            //Cache
            //Transaction vs..
            // Brand addedBrand=

            Brand brandToAdd = _mapper.Map<Brand>(request);   //mapping    //new(request.name) elle newlemek yerine mappleme özelliğini kullanıyoruz.         //aynı işlemde eşleşen kısımları, Brand nesnesinde oluşturuyor  
            _brandDal.Add(brandToAdd);

            //Mapping
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

            //Brand brandToDelete = _brandBusinessRules.FindBrandId(id);
            //brandToDelete.DeletedAt = DateTime.Now;
            //DeleteBrandResponse response = _mapper.Map<DeleteBrandResponse>(brandToDelete);
            //return response;


        }

        public GetBrandListResponse GetList(GetBrandListRequest request)
        {
            //İş kodları
            //validation
            //yetki kontrolü 
            //Cache
            //Transaction vs..
            IList<Brand> brandList = _brandDal.GetList();
            //Brand -> BrandListItemDto
            //IList<BrandListItemDto> -> GetBrandListResponseList<BrandListItemDto>
            //brandList.Items diye bir alan yok bu yüzden mapping yapılacak

            GetBrandListResponse response = _mapper.Map<GetBrandListResponse>(brandList);
            return response;
        }



        public UpdateBrandResponse Update(UpdateBrandRequest request)
        {

            //Brand brandToUpdate = _brandBusinessRules.FindBrandId(id);
            //brandToUpdate.Name = request.Name;
            //brandToUpdate.UpdatedAt = DateTime.Now;
            //UpdateBrandResponse response = _mapper.Map<UpdateBrandResponse>(brandToUpdate);
            //return response;
            Brand? BrandToUpdate = _brandDal.Get(predicate: brand => brand.Id == request.Id);
            _brandBusinessRules.CheckIfBrandExists(BrandToUpdate);

            BrandToUpdate = _mapper.Map(request, BrandToUpdate);
            Brand updatedBrand = _brandDal.Update(BrandToUpdate!);
            var response = _mapper.Map<UpdateBrandResponse>(updatedBrand);
            return response;
        }
        //AddBrandResponse IBrandService.Add(AddBrandRequest request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}