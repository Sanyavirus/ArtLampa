using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private RepositoryContext context;

        public ProductRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public Product GetEntityById(int id)
        {
           return context.GetProducts()[id];
        }

        public IList<Product> GetEntities()
        {
            return context.GetProducts();
        }

        public IList<Product> GetEntities(SpecialSearchParameters searchParameters)
        {
            throw new System.NotImplementedException();
        }

        public bool CreateEntity(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateEntity(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteEntity(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public bool CreateEntities(IEnumerable<Product> entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateEntities(IEnumerable<Product> entity)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteEntities(IEnumerable<Product> entity)
        {
            throw new System.NotImplementedException();
        }
    }
}