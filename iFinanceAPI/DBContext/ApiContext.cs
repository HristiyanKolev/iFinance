using FinanceControlServices.Models;
using Microsoft.EntityFrameworkCore;
using UsersService.Models;

namespace iFinanceAPI.DBContext
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        public DbSet<MonthlyBalanceServiceModel> MonthlyBalances { get; set; } = null!;
        public DbSet<RecurringEntityServiceModel> RecurringEntities { get; set; } = null!;
        public DbSet<EntityServiceModel> Entities { get; set; } = null!;
        public DbSet<UserServiceModel> Users { get; set; } = null!;
    }
}
