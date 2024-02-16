using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class BrandBusinessRules
    {
        private readonly IBrandDal _brandDal;
        public BrandBusinessRules(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void CheckIfBrandNameExists(string brandName)
        {
            bool isExists = _brandDal.Get(brand => brand.Name == brandName) is not null;
            // bool isExists = _brandDal.GetList().Any(b => b.Name == brandName);

            if (isExists)
            {
                throw new BusinessException("Brand already exists.");
            }

        }

        public Brand FindBrandId(int id)
        {
            Brand brand = _brandDal.GetList().SingleOrDefault(b => b.Id == id);
            return brand;
        }
        public void CheckIfBrandExists(Brand? brand)
        {
            if (brand is null)
                throw new NotFoundException("Brand not found.");
        }


    }
}