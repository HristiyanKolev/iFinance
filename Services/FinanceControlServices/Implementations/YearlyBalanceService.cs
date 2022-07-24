using FinanceControlServices.Contracts;
using FinanceControlServices.DBContext;
using FinanceControlServices.Models;

namespace FinanceControlServices.Implementations
{
    public class YearlyBalanceService : IYearlyBalanceService
    {
        private readonly FinanceControlServiceContext _context;

        public YearlyBalanceService(FinanceControlServiceContext context)
        {
            this._context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<YearlyBalanceServiceModel> GetYearlyBalances()
        {
            return _context.YearlyBalances.ToList();
        }

        public YearlyBalanceServiceModel GetYearlyBalanceByID(int id)
        {
            return _context.YearlyBalances.FirstOrDefault(x => x.Id == id);
        }

        public void CreateYearlyBalance(YearlyBalanceServiceModel yearlyBalanceServiceModel)
        {
            if (yearlyBalanceServiceModel == null)
            {
                throw new ArgumentNullException(nameof(yearlyBalanceServiceModel));
            }

            _context.YearlyBalances.Add(yearlyBalanceServiceModel);

            SaveChanges();
        }

        public void DeleteYearlyBalance(YearlyBalanceServiceModel yearlyBalanceServiceModel)
        {
            //NOTHING

            SaveChanges();
        }

        public void UpdateYearlyBalance(YearlyBalanceServiceModel yearlyBalanceServiceModel)
        {
            if (yearlyBalanceServiceModel == null)
            {
                throw new ArgumentNullException(nameof(yearlyBalanceServiceModel));
            }

            _context.YearlyBalances.Remove(yearlyBalanceServiceModel);

            _context.SaveChanges();
        }

        public decimal GetAggregatedValue()
        {
            return GetYearlyBalances().Select(v => v.Value).Sum();
        }
    }
}
