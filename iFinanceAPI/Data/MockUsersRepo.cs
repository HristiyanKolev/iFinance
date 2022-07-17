using iFinanceAPI.Models;

namespace iFinanceAPI.Data
{
    public class MockUsersRepo : IUserRepo
    {

        public IEnumerable<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User { Id = 1, Name = "HristiyanKolev", Password = "123456", Email = null, PhoneNumber = null},
                new User { Id = 2, Name = "StoyanRangelov", Password = "654321", Email = null, PhoneNumber = null},
                new User { Id = 3, Name = "GeorgiHorozov", Password = "142536", Email = null, PhoneNumber = null}
            };

            return users;
        }
        public User GetUserByID(int id)
        {
            return new User { Id = 1, Name = "HristiyanKolev", Password = "123456", Email = null, PhoneNumber = null};
        }
    }
}
