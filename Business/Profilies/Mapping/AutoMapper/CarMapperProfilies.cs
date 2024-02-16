using AutoMapper;
using Business.Dtos.Car;
using Business.Request.Car;
using Business.Responses.Car;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CarMapperProfiles : Profile
    {
        public CarMapperProfiles()
        {
            CreateMap<AddCarRequest, Car>();
            CreateMap<Car, AddCarResponse>();
            CreateMap<UpdateCarRequest, Car>();
            CreateMap<Car, UpdateCarResponse>();
            CreateMap<DeleteCarRequest, Car>();
            CreateMap<Car, DeleteCarResponse>();
            CreateMap<Car, CarListItemDto>();
            CreateMap<IList<Car>, GetCarListResponse>().ForMember(destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src));

        }
    }
}