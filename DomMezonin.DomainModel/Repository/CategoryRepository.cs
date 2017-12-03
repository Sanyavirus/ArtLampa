using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        private RepositoryContext context;

        public CategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }
    }
}