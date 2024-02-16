using Business.Dtos.Transmission;

namespace Business.Responses.Transmission
{
    public class GetTransmissionListResponse
    {
        public ICollection<TransmissionListItemDto> Items { get; set; }
        public GetTransmissionListResponse()
        {
            Items = Array.Empty<TransmissionListItemDto>();
        }
        public GetTransmissionListResponse(ICollection<TransmissionListItemDto> items)
        {
            Items = items;
        }
    }
}