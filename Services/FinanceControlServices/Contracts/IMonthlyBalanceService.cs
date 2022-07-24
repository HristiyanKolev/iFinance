using FinanceControlServices.Models;

namespace FinanceControlServices.Contracts
{
    public interface IMonthlyBalanceService
    {
        bool SaveChanges();

        IEnumerable<MonthlyBalanceServiceModel> GetMonthlyBalances();
        MonthlyBalanceServiceModel GetMonthlyBalanceByID(int id);
        void CreateMonthlyBalance(MonthlyBalanceServiceModel monthlyBalanceServiceModel);
        void UpdateMonthlyBalance(MonthlyBalanceServiceModel monthlyBalanceServiceModel);
        void DeleteMonthlyBalance(MonthlyBalanceServiceModel monthlyBalanceServiceModel);

        decimal GetAggregatedValue();
    }
}
