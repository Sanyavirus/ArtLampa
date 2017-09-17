using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        TEntity GetEntityById(int id);
        IList<TEntity> GetEntities();
        IList<TEntity> GetEntities(SpecialSearchParameters searchParameters);
        bool CreateEntity(TEntity entity);
        bool UpdateEntity(TEntity entity);
        bool DeleteEntity(TEntity entity);
        bool CreateEntities(IEnumerable<TEntity> entity);
        bool UpdateEntities(IEnumerable<TEntity> entity);
        bool DeleteEntities(IEnumerable<TEntity> entity);
    }
}


