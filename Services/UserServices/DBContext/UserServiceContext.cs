using Microsoft.EntityFrameworkCore;
using UsersService.Models;

namespace UsersServices.DBContext
{
    public class UserServiceContext : DbContext
    {
        public UserServiceContext(DbContextOptions<UserServiceContext> options) : base(options)
        {

        }

        public DbSet<UserServiceModel> Users { get; set; } = null!;
    }
}
