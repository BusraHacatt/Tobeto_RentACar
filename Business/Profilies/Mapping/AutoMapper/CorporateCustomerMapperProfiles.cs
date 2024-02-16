using AutoMapper;
using Business.Dtos.CorporateCustomer;
using Business.Request.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CorporateCustomerMapperProfiles : Profile
    {
        public CorporateCustomerMapperProfiles()
        {
            CreateMap<AddCorporateRequest, CorporateCustomer>();
            CreateMap<CorporateCustomer, AddCorporateResponse>();
            CreateMap<UpdateCorporateRequest, CorporateCustomer>();
            CreateMap<CorporateCustomer, UpdateCorporateResponse>();
            CreateMap<CorporateCustomer, CorporateListItemDto>();
            CreateMap<IList<CorporateCustomer>, GetCorporateListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<CorporateCustomer, DeleteCorporateResponse>();
            CreateMap<CorporateCustomer, GetCorporateByIdResponse>();
        }
    }
}
