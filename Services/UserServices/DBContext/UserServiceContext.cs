using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserServices.DBContext
{
    public class UserServiceContext : DbContext
    {
        public UserServiceContext(DbContextOptions<UserServiceContext> options) : base(options)
        {

        }

        public DbSet<UserServiceModel> Users { get; set; } = null!;
    }
}
