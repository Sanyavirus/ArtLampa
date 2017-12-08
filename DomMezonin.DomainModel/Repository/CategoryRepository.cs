using System.Collections.Generic;
using System.Data.Entity;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}