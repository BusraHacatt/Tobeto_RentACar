using AutoMapper;
using Business.Dtos.Brand;
using Business.Responses.Brand;
using Entities.Concrete;
using Business.Request.Brand;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class BrandMapperProfiles : Profile
    {
        public BrandMapperProfiles()
        {
            CreateMap<AddBrandRequest, Brand>();
            CreateMap<Brand, AddBrandResponse>();

            CreateMap<Brand, BrandListItemDto>();
            CreateMap<IList<Brand>, GetBrandListResponse>()
                .ForMember(
                    destinationMember: dest => dest.Items,
                    memberOptions: opt => opt.MapFrom(mapExpression: src => src)
                );
        }
    }
}