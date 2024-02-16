using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.User;
using Business.Request.User;
using Business.Responses.User;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly UserBusinessRules _businessRules;
        private IMapper _mapper;

        public UserManager(IUserDal userDal, UserBusinessRules businessRules, IMapper mapper)
        {
            _userDal = userDal;
            _businessRules = businessRules;
            _mapper = mapper;
        }

        public AddUserResponse Add(AddUserRequest request)
        {
            ValidationTool.Validate(new AddUserRequestValidator(), request);
            User userToAdd = _mapper.Map<User>(request);
            _userDal.Add(userToAdd);
            AddUserResponse response = _mapper.Map<AddUserResponse>(userToAdd);
            return response;

        }

        public DeleteUserResponse Delete(DeleteUserRequest request)
        {
            User? userToDelete = _userDal.Get(predicate: user => user.Id == request.Id);
            _businessRules.CheckIfUserExists(userToDelete);
            User deletedUser = _userDal.Delete(userToDelete!);
            DeleteUserResponse response = _mapper.Map<DeleteUserResponse>(deletedUser);
            return response;
        }

        public GetUserListResponse GetList(GetUserListRequest request)
        {
            IList<User> userList = _userDal.GetList();
            GetUserListResponse response = _mapper.Map<GetUserListResponse>(userList);
            return response;
        }

        public GetUserByIdResponse GetById(GetUserByIdRequest request)
        {
            User? user = _userDal.Get(predicate: user => user.Id == request.Id);
            GetUserByIdResponse response = _mapper.Map<GetUserByIdResponse>(user);
            return response;
        }

        public UpdateUserResponse Update(UpdateUserRequest request)
        {
            User? userToUpdate = _userDal.Get(predicate: user => user.Id == request.Id);
            _businessRules.CheckIfUserExists(userToUpdate);
            userToUpdate = _mapper.Map(request, userToUpdate);
            User updatedUser = _userDal.Update(userToUpdate!);
            var response = _mapper.Map<UpdateUserResponse>(updatedUser);
            return response;
        }
    }
}
