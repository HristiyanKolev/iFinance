using FinanceControlServices.Models;

namespace FinanceControlServices.Contracts
{
    public interface IQuarterlyBalanceService
    {
        bool SaveChanges();

        IEnumerable<QuarterlyBalanceServiceModel> GetQuarterlyBalances();
        QuarterlyBalanceServiceModel GetQuarterlyBalanceByID(int id);
        void CreateQuarterlyBalance(QuarterlyBalanceServiceModel quarterlyBalanceServiceModel);
        void UpdateQuarterlyBalance(QuarterlyBalanceServiceModel quarterlyBalanceServiceModel);
        void DeleteQuarterlyBalance(QuarterlyBalanceServiceModel quarterlyBalanceServiceModel);

        decimal GetAggregatedValue();
    }
}
