using Business.Dtos.CorporateCustomer;

namespace Business.Responses.CorporateCustomer
{
    public class GetCorporateListResponse
    {
        public GetCorporateListResponse(ICollection<CorporateListItemDto> ıtems)
        {
            Items = ıtems;
        }
        public GetCorporateListResponse()
        {
            Items = Array.Empty<CorporateListItemDto>();
        }
        public ICollection<CorporateListItemDto> Items { get; set; }

    }
}