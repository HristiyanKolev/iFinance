using FinanceControlServices.Models;

namespace FinanceControlServices.Contracts
{
    public interface IYearlyBalanceService
    {
        bool SaveChanges();

        IEnumerable<YearlyBalanceServiceModel> GetYearlyBalances();
        YearlyBalanceServiceModel GetYearlyBalanceByID(int id);
        void CreateYearlyBalance(YearlyBalanceServiceModel yearlyBalanceServiceModel);
        void UpdateYearlyBalance(YearlyBalanceServiceModel yearlyBalanceServiceModel);
        void DeleteYearlyBalance(YearlyBalanceServiceModel yearlyBalanceServiceModel);

        decimal GetAggregatedValue();
    }
}
