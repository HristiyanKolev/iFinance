using UserService.Models;

namespace UserServices.Contracts
{
    public interface IUserMethods
    {
        public IEnumerable<UserModel> GetUsers();
        public UserModel GetUserByID(int id);
        
    }
}