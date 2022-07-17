using UsersService.Models;

namespace UsersServices.Contracts
{
    public interface IUserMethods
    {
        public IEnumerable<UserModel> GetUsers();
        public UserModel GetUserByID(int id);
        
    }
}