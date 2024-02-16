using Business.Dtos.Customer;

namespace Business.Responses.Customer
{
    public class GetCustomerListResponse
    {
        public ICollection<CustomerListItemDto> Items { get; set; }
        public GetCustomerListResponse()
        {
            Items = Array.Empty<CustomerListItemDto>();
            Items = Array.Empty<CustomerListItemDto>();
        }

        public GetCustomerListResponse(ICollection<CustomerListItemDto> ıtems)
        {
            Items = ıtems;
        }
    }
}