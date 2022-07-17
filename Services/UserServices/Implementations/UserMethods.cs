using UserService.Models;
using UserServices.Contracts;
using UserServices.DBContext;

namespace UserServices.Implementations
{
    public class UserMethods : IUserMethods
    {
        private readonly UserContext _context;

        public UserMethods(UserContext context)
        {
            this._context = context;
        }

        public IEnumerable<UserModel> GetUsers()
        {
            return _context.Users.ToList();
        }

        public UserModel GetUserByID(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
