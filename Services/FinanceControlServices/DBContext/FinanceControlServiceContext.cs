using Microsoft.EntityFrameworkCore;
using FinanceControlServices.Models;

namespace FinanceControlServices.DBContext
{
    public class FinanceControlServiceContext : DbContext
    {
        public FinanceControlServiceContext(DbContextOptions<FinanceControlServiceContext> options) : base(options)
        {

        }

        public DbSet<YearlyBalanceServiceModel> YearlyBalances { get; set; } = null!;
    }
}
