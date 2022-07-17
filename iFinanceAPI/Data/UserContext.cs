using iFinanceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace iFinanceAPI.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; } = null!;
    }
}
