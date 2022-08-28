using UsersService.Models;
using UsersServices.Contracts;
using UsersServices.DBContext;

namespace UsersServices.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserServiceContext _context;

        public UserService(UserServiceContext context)
        {
            this._context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<UserServiceModel> GetUsers()
        {
            return _context.Users.ToList();
        }

        public UserServiceModel GetUserByID(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void CreateUser(UserServiceModel userServiceModel)
        {
            CheckIfUsernameIsTaken(userServiceModel);

            userServiceModel.UserType = userServiceModel.UserType.ToLower();
            
            userServiceModel.DateCreated = DateTime.Now;

            _context.Users.Add(userServiceModel);

            SaveChanges();
        }

        public void UpdateUser(UserServiceModel userServiceModel)
        {
            //NOTHING

            SaveChanges();
        }

        public void DeleteUser(UserServiceModel userServiceModel)
        {
            if (userServiceModel == null)
            {
                throw new ArgumentNullException(nameof(userServiceModel));
            }

            _context.Users.Remove(userServiceModel);

            _context.SaveChanges();
        }

        private void CheckIfUsernameIsTaken(UserServiceModel userServiceModel)
        {
            IEnumerable<UserServiceModel> users = GetUsers();
            if (users.FirstOrDefault(u => u.UserName == userServiceModel.UserName) != null)
            {
                throw new ArgumentException("UserName already in use");
            }
        }
    }
}
