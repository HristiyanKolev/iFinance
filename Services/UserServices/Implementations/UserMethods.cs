using UsersService.Models;
using UsersServices.Contracts;
using UsersServices.DBContext;

namespace UserServices.Implementations
{
    public class User : IUserMethods
    {
        private readonly UsersContext _context;

        public User(UsersContext context)
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
