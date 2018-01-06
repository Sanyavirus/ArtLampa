using System.Collections.Generic;
using System.Data.Entity;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class ProductRepository : RepositoryBase<Product>
    {

        public ProductRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}