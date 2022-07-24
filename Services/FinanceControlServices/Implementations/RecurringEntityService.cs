using FinanceControlServices.Contracts;
using FinanceControlServices.DBContext;
using FinanceControlServices.Models;

namespace FinanceControlServices.Implementations
{
    public class RecurringEntityService : IRecurringEntityService
    {
        private readonly FinanceControlServiceContext _context;

        public RecurringEntityService(FinanceControlServiceContext context)
        {
            this._context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<RecurringEntityServiceModel> GetRecurringEntities()
        {
            return _context.RecurringEntities.ToList();
        }

        public RecurringEntityServiceModel GetRecurringEntityByID(int id)
        {
            return _context.RecurringEntities.FirstOrDefault(x => x.Id == id);
        }

        public void CreateRecurringEntity(RecurringEntityServiceModel recurringEntityServiceModel)
        {
            if (recurringEntityServiceModel == null)
            {
                throw new ArgumentNullException(nameof(recurringEntityServiceModel));
            }

            _context.RecurringEntities.Add(recurringEntityServiceModel);

            SaveChanges();
        }

        public void DeleteRecurringEntity(RecurringEntityServiceModel recurringEntityServiceModel)
        {
            //NOTHING

            SaveChanges();
        }

        public void UpdateRecurringEntity(RecurringEntityServiceModel recurringEntityServiceModel)
        {
            if (recurringEntityServiceModel == null)
            {
                throw new ArgumentNullException(nameof(recurringEntityServiceModel));
            }

            _context.RecurringEntities.Remove(recurringEntityServiceModel);

            _context.SaveChanges();
        }

        public decimal GetAggregatedValue()
        {
            return GetRecurringEntities().Select(v => v.Value).Sum();
        }
    }
}
