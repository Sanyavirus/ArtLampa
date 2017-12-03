using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class ProductRepository : RepositoryBase<Product>
    {
        private RepositoryContext context;

        public ProductRepository(RepositoryContext context)
        {
            this.context = context;
        }
        
    }
}