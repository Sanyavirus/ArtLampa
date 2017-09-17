using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        private RepositoryContext context;

        public CategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public Category GetEntityById(int id)
        {
           return context.GetCategories()[id];
        }

        public IList<Category> GetEntities()
        {
            return context.GetCategories();
        }

        public IList<Category> GetEntities(SpecialSearchParameters searchParameters)
        {
            throw new System.NotImplementedException();
        }

        public bool CreateEntity(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateEntity(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteEntity(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public bool CreateEntities(IEnumerable<Category> entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateEntities(IEnumerable<Category> entity)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteEntities(IEnumerable<Category> entity)
        {
            throw new System.NotImplementedException();
        }
    }
}