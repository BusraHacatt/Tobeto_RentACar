using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class ModelBusinessRules
    {
        private readonly IModelDal _modelDal;
        public ModelBusinessRules(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }


        public Model FindBrandId(int id)
        {
            Model model = _modelDal.GetList().SingleOrDefault(b => b.Id == id);
            return model;
        }
        public void CheckIfModelExists(Model? model)
        {
            if (model is null)
                throw new NotFoundException("Model not found.");
        }
        public void CheckIfModelNameExists(string modelName)
        {
            bool isExists = _modelDal.Get(model => model.Name == modelName) is not null;
            // bool isExists = _brandDal.GetList().Any(b => b.Name == brandName);

            if (isExists)
            {
                throw new BusinessException("Model already exists.");
            }

        }
        public void CheckIfModelYearShouldBeInLast20Years(short year)
        {
            if (year < DateTime.UtcNow.AddYears(-20).Year)
                throw new BusinessException("Model year should be in last 20 years.");
        }
    }
}