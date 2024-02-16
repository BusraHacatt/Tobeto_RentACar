using Business.Request.User;
using Business.Responses.User;

namespace Business.Abstract
{
    public interface IUserService
    {
        public AddUserResponse Add(AddUserRequest request);
        public DeleteUserResponse Delete(DeleteUserRequest request);
        public UpdateUserResponse Update(UpdateUserRequest request);
        public GetUserListResponse GetList(GetUserListRequest request);
        public GetUserByIdResponse GetById(GetUserByIdRequest request);
    }
}
