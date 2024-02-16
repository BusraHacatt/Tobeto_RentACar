using Business.Dtos.Brand;

namespace Business.Responses.Brand
{
    public class GetBrandListResponse
    {
        public ICollection<BrandListItemDto> Items { get; set; }
        public GetBrandListResponse()
        {
            //newleme yaparken parmaetre vermezsem boş bir array oluştursun,
            Items = Array.Empty<BrandListItemDto>();
        }
        public GetBrandListResponse(ICollection<BrandListItemDto> items)
        {
            Items = items;
        }
    }
}