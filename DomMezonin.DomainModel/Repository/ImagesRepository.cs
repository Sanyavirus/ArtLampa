using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class ImagesRepository : RepositoryBase<Image>
    {
        private RepositoryContext context;
        public ImagesRepository(RepositoryContext context)
        {
            this.context = context;
        }
        
    }
}