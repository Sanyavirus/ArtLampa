using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomMezonin.DomainModel.Entity;
using System.Data.Entity;
using System.Linq.Expressions;

namespace DomMezonin.DomainModel.Repository
{
    public abstract class RepositoryBase<TEntity>
        where TEntity : EntityBase
    {
        DbContext dbContext;
        DbSet<TEntity> entitySet;
        
        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
            entitySet = dbContext.Set<TEntity>();
        }

        public virtual TEntity GetEntity(long id)
        {
            return entitySet.FirstOrDefault(e => e.Id == id);
        }

        public virtual IQueryable<TEntity> GetEntities(Expression<Func<TEntity, bool>> expr)
        {
            return entitySet.Where(expr);
        }

        public virtual IQueryable<TEntity> GetEntities()
        {
            return entitySet.AsQueryable();
        }

        public virtual int CreateEntity(TEntity entity)
        {
            entitySet.Add(entity);
            return dbContext.SaveChanges();
        }

        public virtual int UpdateEntity(TEntity entity)
        {
            entitySet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
            return dbContext.SaveChanges();
        }

        public virtual int DeleteEntity(TEntity entity)
        {
            entitySet.Remove(entity);
            return dbContext.SaveChanges();
          
        }
        
    }
}
