using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        public bool CreateEntities(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public bool CreateEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntities(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }
    
        public bool DeleteEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetEntities()
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetEntities(SpecialSearchParameters searchParameters)
        {
            throw new NotImplementedException();
        }

        public TEntity GetEntityById(long id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntities(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
