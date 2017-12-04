using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public abstract class RepositoryBase<TEntity>
        where TEntity : EntityBase
    {
        protected RepositoryContext repositoryContext;

        public virtual TEntity GetEntityById(int id)
        {

        }

        public virtual IList<TEntity> GetEntities()
        {
            throw new NotImplementedException();
        }

        public virtual IList<TEntity> GetEntities(SpecialSearchParameters searchParameters)
        {
            throw new NotImplementedException();
        }

        public virtual bool CreateEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool UpdateEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool DeleteEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool CreateEntities(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool UpdateEntities(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool DeleteEntities(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }
    }
}
