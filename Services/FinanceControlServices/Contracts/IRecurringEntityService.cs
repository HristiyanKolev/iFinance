using FinanceControlServices.Models;

namespace FinanceControlServices.Contracts
{
    public interface IRecurringEntityService
    {
        bool SaveChanges();

        IEnumerable<RecurringEntityServiceModel> GetRecurringEntities();
        RecurringEntityServiceModel GetRecurringEntityByID(int id);
        void CreateRecurringEntity(RecurringEntityServiceModel recurringEntityServiceModel);
        void UpdateRecurringEntity(RecurringEntityServiceModel recurringEntityServiceModel);
        void DeleteRecurringEntity(RecurringEntityServiceModel recurringEntityServiceModel);

        decimal GetAggregatedValue();
    }
}