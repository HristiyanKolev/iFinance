using InputModels.UserInputModels;
using UserService.Models;
using UserServices.Contracts;
using UserServices.DBContext;

namespace UserServices.Implementations
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
            if(userServiceModel == null)
            {
                throw new ArgumentNullException(nameof(userServiceModel));
            }

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
    }
}
