using iFinanceAPI.Models;

namespace iFinanceAPI.Data
{
    public interface IUserRepo
    {
        public IEnumerable<User> GetUsers();
        public User GetUserByID(int id);
    }
}
