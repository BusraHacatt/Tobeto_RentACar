using Business.Dtos.IndividualCustomer;

namespace Business.Responses.IndividualCustomer
{
    public class GetIndividualListResponse
    {
        public GetIndividualListResponse(ICollection<IndividualListItemDto> ıtems)
        {
            Items = ıtems;
        }
        public GetIndividualListResponse()
        {
            Items = Array.Empty<IndividualListItemDto>();
        }

        public ICollection<IndividualListItemDto> Items { get; set; }
    }
}
