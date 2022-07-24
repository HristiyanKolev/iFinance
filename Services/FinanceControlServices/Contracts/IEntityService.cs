using FinanceControlServices.Models;

namespace FinanceControlServices.Contracts
{
    public interface IEntityService
    {
        bool SaveChanges();

        IEnumerable<EntityServiceModel> GetEntities();
        EntityServiceModel GetEntityByID(int id);
        void CreateEntity(EntityServiceModel entityServiceModel);
        void UpdateEntity(EntityServiceModel entityServiceModel);
        void DeleteEntity(EntityServiceModel entityServiceModel);

        decimal GetAggregatedValue();
    }
}
