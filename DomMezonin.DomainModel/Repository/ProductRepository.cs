using DomMezonin.DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Repository
{
    class ProductRepository : IRepository<Product>
    {

        private RepositoryContext 

        public Product GetEntityById(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetEntities()
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetEntities(SpecialSearchParameters searchParameters)
        {
            throw new NotImplementedException();
        }

        public bool CreateEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool CreateEntities(IEnumerable<Product> entity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntities(IEnumerable<Product> entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntities(IEnumerable<Product> entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
