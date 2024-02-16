using AutoMapper;
using Business.Dtos.Transmission;
using Business.Request.Transmission;
using Business.Responses.Transmission;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class TransmissionMapperProfiles : Profile
    {
        public TransmissionMapperProfiles()
        {
            CreateMap<AddTransmissionRequest, Transmission>();
            CreateMap<Transmission, AddTransmissionResponse>();
            CreateMap<UpdateTransmissionRequest, Transmission>();
            CreateMap<Transmission, UpdateTransmissionResponse>();
            CreateMap<DeleteTransmissionRequest, Transmission>();
            CreateMap<Transmission, DeleteTransmissionResponse>();

            CreateMap<Transmission, TransmissionListItemDto>();
            CreateMap<IList<Transmission>, GetTransmissionListResponse>()
                .ForMember(destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src));
        }
    }
}
