using Business.Requests.User;
using Core.Utilities.Security.JWT;

namespace Business.Abstract
{
    public interface IUserService
    {

        void Register(RegisterRequest request);
        AccessToken Login(LoginRequest request); //TODO: return type: JWT 

    }
}
