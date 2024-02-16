using AutoMapper;
using Business.Dtos.Model;
using Business.Request.Model;
using Business.Responses.Model;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class ModelMapperProfiles : Profile
    {
        public ModelMapperProfiles()
        {
            CreateMap<AddModelRequest, Model>();
            CreateMap<Model, AddModelResponse>();
            CreateMap<UpdateModelRequest, Model>();
            CreateMap<Model, UpdateModelResponse>();
            CreateMap<DeleteModelRequest, Model>();
            CreateMap<Model, DeleteModelResponse>();
            CreateMap<Model, ModelListItemDto>();
            CreateMap<IList<Model>, GetModelListResponse>().ForMember(destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src));

        }
    }
}