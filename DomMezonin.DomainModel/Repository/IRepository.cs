using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        TEntity GetEntityById(long id);
        IList<TEntity> GetEntities();
        IList<TEntity> GetEntities(SpecialSearchParameters searchParameters);
        bool CreateEntity(EntityBase entity);
        bool UpdateEntity(EntityBase entity);
        bool DeleteEntity(EntityBase entity);
        bool CreateEntities(IEnumerable<EntityBase> entity);
        bool UpdateEntities(IEnumerable<EntityBase> entity);
        bool DeleteEntities(IEnumerable<EntityBase> entity);
    }
}
