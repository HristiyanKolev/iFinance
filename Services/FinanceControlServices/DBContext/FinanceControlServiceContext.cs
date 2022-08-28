using Microsoft.EntityFrameworkCore;
using FinanceControlServices.Models;

namespace FinanceControlServices.DBContext
{
    public class FinanceControlServiceContext : DbContext
    {
        public FinanceControlServiceContext(DbContextOptions<FinanceControlServiceContext> options) : base(options)
        {

        }

        public DbSet<MonthlyBalanceServiceModel> MonthlyBalances { get; set; } = null!;
        public DbSet<RecurringEntityServiceModel> RecurringEntities { get; set; } = null!;
        public DbSet<EntityServiceModel> Entities { get; set; } = null!;
    }
}
