using Business.Dtos.User;

namespace Business.Responses.User
{
    public class GetUserListResponse
    {
        public ICollection<UserListItemDto> Items { get; set; }
        public GetUserListResponse()
        {
            Items = Array.Empty<UserListItemDto>();
        }

        public GetUserListResponse(ICollection<UserListItemDto> ıtems)
        {
            Items = ıtems;
        }
    }
}
