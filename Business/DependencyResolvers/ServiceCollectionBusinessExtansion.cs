using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
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
            services
                .AddScoped<IBrandService, BrandManager>()
                .AddScoped<IBrandDal, EfBrandDal>()
                .AddScoped<BrandBusinessRules>();
            services.AddSingleton<IFuelService, FuelManager>().AddSingleton<IFuelDal, EfFuelDal>().AddSingleton<FuelBusinessRules>();
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

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<UserBusinessRules>();

            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();
            services.AddScoped<CustomerBusinessRules>();

            services.AddScoped<IIndividualCustomerService, IndividualCustomerManager>();
            services.AddScoped<IIndividualCustomerDal, EfIndividualCustomerDal>();
            services.AddScoped<IndividualCustomerBusinessRules>();

            services.AddScoped<ICorporateCustomerService, CorporateCustomerManager>();
            services.AddScoped<ICorporateCustomerDal, EfCorporateCustomerDal>();
            services.AddScoped<CorporateCustomerBusinessRules>();




            services.AddAutoMapper(Assembly.GetExecutingAssembly()); 
            services.AddDbContext<RentACarContext>(options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL22")));

            return services;

        }

    }
}
