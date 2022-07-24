using FinanceControlServices.Models;
using FinanceControlServices.Contracts;
using FinanceControlServices.DBContext;

namespace FinanceControlServices.Implementations
{
    public class MonthlyBalanceService : IMonthlyBalanceService
    {
        private readonly FinanceControlServiceContext _context;

        public MonthlyBalanceService(FinanceControlServiceContext context)
        {
            this._context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<MonthlyBalanceServiceModel> GetMonthlyBalances()
        {
            return _context.MonthlyBalances.ToList();
        }

        public MonthlyBalanceServiceModel GetMonthlyBalanceByID(int id)
        {
            return _context.MonthlyBalances.FirstOrDefault(x => x.Id == id);
        }

        public void CreateMonthlyBalance(MonthlyBalanceServiceModel monthlyBalanceServiceModel)
        {
            if (monthlyBalanceServiceModel == null)
            {
                throw new ArgumentNullException(nameof(monthlyBalanceServiceModel));
            }

            _context.MonthlyBalances.Add(monthlyBalanceServiceModel);

            SaveChanges();
        }

        public void DeleteMonthlyBalance(MonthlyBalanceServiceModel monthlyBalanceServiceModel)
        {
            //NOTHING

            SaveChanges();
        }

        public void UpdateMonthlyBalance(MonthlyBalanceServiceModel monthlyBalanceServiceModel)
        {
            if (monthlyBalanceServiceModel == null)
            {
                throw new ArgumentNullException(nameof(monthlyBalanceServiceModel));
            }

            _context.MonthlyBalances.Remove(monthlyBalanceServiceModel);

            _context.SaveChanges();
        }

        public decimal GetAggregatedValue()
        {
            return GetMonthlyBalances().Select(v => v.Value).Sum();
        }
    }
}
