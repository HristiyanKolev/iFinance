using UserService.Models;
using UserServices.Contracts;

namespace UserServices.Implementations
{
    public class MockUserMethods : IUserMethods
    {
        public IEnumerable<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel>()
            {
                new UserModel { Id = 1, Name = "HristiyanKolev", Password = "123456", Email = null, PhoneNumber = null},
                new UserModel { Id = 2, Name = "StoyanRangelov", Password = "654321", Email = null, PhoneNumber = null},
                new UserModel { Id = 3, Name = "GeorgiHorozov", Password = "142536", Email = null, PhoneNumber = null}
            };

            return users;
        }
        public UserModel GetUserByID(int id)
        {
            return new UserModel { Id = 1, Name = "HristiyanKolev", Password = "123456", Email = null, PhoneNumber = null };
        }
    }
}