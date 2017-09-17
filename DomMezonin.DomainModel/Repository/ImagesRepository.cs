using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class ImagesRepository : IRepository<Image>
    {
        private RepositoryContext context;
        public ImagesRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public Image GetEntityById(int id)
        {
           return context.GetImages()[id];
        }

        public IList<Image> GetEntities()
        {
            return context.GetImages();
        }

        public IList<Image> GetEntities(SpecialSearchParameters searchParameters)
        {
            throw new System.NotImplementedException();
        }

        public bool CreateEntity(Image entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateEntity(Image entity)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteEntity(Image entity)
        {
            throw new System.NotImplementedException();
        }

        public bool CreateEntities(IEnumerable<Image> entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateEntities(IEnumerable<Image> entity)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteEntities(IEnumerable<Image> entity)
        {
            throw new System.NotImplementedException();
        }
    }
}