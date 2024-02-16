using AutoMapper;
using Business.Dtos.Fuel;
using Business.Request.Fuel;
using Business.Responses.Fuel;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class FuelMapperProfiles : Profile
    {
        public FuelMapperProfiles()
        {
            CreateMap<AddFuelRequest, Fuel>();
            CreateMap<Fuel, AddFuelResponse>();
            CreateMap<UpdateFuelRequest, Fuel>();
            CreateMap<Fuel, UpdateFuelResponse>();
            CreateMap<DeleteFuelRequest, Fuel>();
            CreateMap<Fuel, DeleteFuelResponse>();
            CreateMap<Fuel, FuelListItemDto>();

            CreateMap<IList<Fuel>, GetFuelListResponse>().ForMember(destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src));

        }
    }
}