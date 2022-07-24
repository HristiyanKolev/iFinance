using FinanceControlServices.Models;
using FinanceControlServices.Contracts;
using FinanceControlServices.DBContext;

namespace FinanceControlServices.Implementations
{
    public class EntityService : IEntityService
    {
        private readonly FinanceControlServiceContext _context;

        public EntityService(FinanceControlServiceContext context)
        {
            this._context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<EntityServiceModel> GetEntities()
        {
            return _context.Entities.ToList();
        }

        public EntityServiceModel GetEntityByID(int id)
        {
            return _context.Entities.FirstOrDefault(x => x.Id == id);
        }

        public void CreateEntity(EntityServiceModel entityServiceModel)
        {
            if (entityServiceModel == null)
            {
                throw new ArgumentNullException(nameof(entityServiceModel));
            }

            _context.Entities.Add(entityServiceModel);

            SaveChanges();
        }
    
        public void DeleteEntity(EntityServiceModel entityServiceModel)
        {
            //NOTHING

            SaveChanges();
         }

        public void UpdateEntity(EntityServiceModel entityServiceModel)
        {
            if (entityServiceModel == null)
            {
                throw new ArgumentNullException(nameof(entityServiceModel));
            }

            _context.Entities.Remove(entityServiceModel);

            _context.SaveChanges();
        }

        public decimal GetAggregatedValue()
        {
            return GetEntities().Select(v => v.Value).Sum();
        }
    }
}
