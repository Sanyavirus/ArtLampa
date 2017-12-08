using System.Collections.Generic;
using System.Data.Entity;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class ImagesRepository : RepositoryBase<Image>
    {
        public ImagesRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}