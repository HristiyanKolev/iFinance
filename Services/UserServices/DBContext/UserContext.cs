using Microsoft.EntityFrameworkCore;
using UsersService.Models;

namespace UsersServices.DBContext
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; } = null!;
    }
}
