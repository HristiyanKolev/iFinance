using FinanceControlServices.Models;
using FinanceControlServices.Contracts;
using FinanceControlServices.DBContext;

namespace FinanceControlServices.Implementations
{
    public class QuarterlyBalanceService : IQuarterlyBalanceService
    {
        private readonly FinanceControlServiceContext _context;

        public QuarterlyBalanceService(FinanceControlServiceContext context)
        {
            this._context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<QuarterlyBalanceServiceModel> GetQuarterlyBalances()
        {
            return _context.QuarterlyBalances.ToList();
        }

        public QuarterlyBalanceServiceModel GetQuarterlyBalanceByID(int id)
        {
            return _context.QuarterlyBalances.FirstOrDefault(x => x.Id == id);
        }

        public void CreateQuarterlyBalance(QuarterlyBalanceServiceModel quarterlyBalanceServiceModel)
        {
            if (quarterlyBalanceServiceModel == null)
            {
                throw new ArgumentNullException(nameof(quarterlyBalanceServiceModel));
            }

            _context.QuarterlyBalances.Add(quarterlyBalanceServiceModel);

            SaveChanges();
        }

        public void DeleteQuarterlyBalance(QuarterlyBalanceServiceModel quarterlyBalanceServiceModel)
        {
            //NOTHING

            SaveChanges();
        }

        public void UpdateQuarterlyBalance(QuarterlyBalanceServiceModel quarterlyBalanceServiceModel)
        {
            if (quarterlyBalanceServiceModel == null)
            {
                throw new ArgumentNullException(nameof(quarterlyBalanceServiceModel));
            }

            _context.QuarterlyBalances.Remove(quarterlyBalanceServiceModel);

            _context.SaveChanges();
        }

        public decimal GetAggregatedValue()
        {
            return GetQuarterlyBalances().Select(v => v.Value).Sum();
        }
    }
}