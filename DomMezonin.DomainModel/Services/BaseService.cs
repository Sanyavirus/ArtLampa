using DomMezonin.DomainModel.Entity;
using DomMezonin.DomainModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Services
{
    public abstract class BaseService<TEntity> : IService<TEntity> where TEntity : EntityBase
    {
        protected RepositoryBase<TEntity> repo;
        
        public BaseService(RepositoryBase<TEntity> repo)
        {
            this.repo = repo;
        }

        public TEntity GetEntity(long id)
        {
            return repo.GetEntity(id);
        }

        public IQueryable<TEntity> GetEntities()
        {
           return repo.GetEntities();
        }

        public int UpdateEntity(TEntity entity)
        {
            return repo.UpdateEntity(entity);
        }

        public int DeleteEntity(TEntity entity)
        {
            return repo.DeleteEntity(entity);
        }

        public int CreateEntity(TEntity entity)
        {
            return repo.CreateEntity(entity);
        }

        public void CreateEntities(IEnumerable<TEntity> entities)
        {
            foreach(TEntity entity in entities)
            {
                repo.CreateEntity(entity);
            }
        }

        public void UpdateEntities(IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                repo.UpdateEntity(entity);
            }
        }

        public void DeleteEntities(IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                repo.DeleteEntity(entity);
            }
        }

    }

}
