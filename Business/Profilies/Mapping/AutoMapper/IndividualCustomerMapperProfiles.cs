using AutoMapper;
using Business.Dtos.IndividualCustomer;
using Business.Request.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class IndividualCustomerMapperProfiles : Profile
    {
        public IndividualCustomerMapperProfiles()
        {
            CreateMap<AddIndividualRequest, IndividualCustomer>();
            CreateMap<IndividualCustomer, AddIndividualResponse>();
            CreateMap<UpdateIndividualRequest, IndividualCustomer>();
            CreateMap<IndividualCustomer, UpdateIndividualResponse>();
            CreateMap<IndividualCustomer, IndividualListItemDto>();
            CreateMap<IList<IndividualCustomer>, GetIndividualListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<IndividualCustomer, DeleteIndividualResponse>();
            CreateMap<IndividualCustomer, GetIndividualByIdResponse>();
        }
    }
}
