using FinanceControlServices.Models;
using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace iFinanceAPI.DBContext
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        public DbSet<YearlyBalanceServiceModel> YearlyBalances { get; set; } = null!;
        public DbSet<UserServiceModel> Users { get; set; } = null!;
    }
}
