using InputModels.UserInputModels;
using UsersService.Models;

namespace UsersServices.Contracts
{
    public interface IUserService
    {
        bool SaveChanges();

        IEnumerable<UserServiceModel> GetUsers();
        UserServiceModel GetUserByID(int id);
        void CreateUser(UserServiceModel userServiceModel);
        void UpdateUser(UserServiceModel userServiceModel);
        void DeleteUser(UserServiceModel userServiceModel);
    }
}