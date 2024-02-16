using Business.Dtos.Model;

namespace Business.Responses.Model
{
    public class GetModelListResponse
    {
        public ICollection<ModelListItemDto> Items { get; set; }
        public GetModelListResponse()
        {
            Items = Array.Empty<ModelListItemDto>();
        }
        public GetModelListResponse(ICollection<ModelListItemDto> items)
        {
            Items = items;
        }

    }
}