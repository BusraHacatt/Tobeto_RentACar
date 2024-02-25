using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete.InMemory;
using DataAccess.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.DependencyResolvers
{
    public static class ServiceCollectionBusinessExtansion
    {

        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenHelper, JwtTokenHelper>();

            services
                .AddScoped<IBrandService, BrandManager>()
                .AddScoped<IBrandDal, EfBrandDal>()
                .AddScoped<BrandBusinessRules>();
            services
               .AddScoped<IFuelService, FuelManager>()
               .AddScoped<IFuelDal, EfFuelDal>()
               .AddScoped<FuelBusinessRules>();
            services
                .AddScoped<ITransmissionService, TransmissionManager>()
                .AddScoped<ITransmissionDal, EfTransmissionDal>()
                .AddScoped<TransmissionBusinessRules>();

            services.AddScoped<IModelService, ModelManager>();
            services.AddScoped<IModelDal, EfModelDal>();
            services.AddScoped<ModelBusinessRules>();

            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<ICarDal, EfCarDal>();
            services.AddScoped<CarBusinessRules>();

         
          

            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();
            services.AddScoped<CustomerBusinessRules>();

            services.AddScoped<IIndividualCustomerService, IndividualCustomerManager>();
            services.AddScoped<IIndividualCustomerDal, EfIndividualCustomerDal>();
            services.AddScoped<IndividualCustomerBusinessRules>();

            services.AddScoped<ICorporateCustomerService, CorporateCustomerManager>();
            services.AddScoped<ICorporateCustomerDal, EfCorporateCustomerDal>();
            services.AddScoped<CorporateCustomerBusinessRules>();

            services
           .AddScoped<IUserService, UserManager>()
           .AddScoped<IUserDal, EfUserDal>();


            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddDbContext<RentACarContext>(options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL22")));

            return services;

        }

    }
}
