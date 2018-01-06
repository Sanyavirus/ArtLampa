using DomMezonin.DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomMezonin.DomainModel.Repository;

namespace DomMezonin.DomainModel.Services
{
    public class ProductService : BaseService<Product>
    {
        public ProductService(RepositoryBase<Product> repo) : base(repo)
        {
        }

        //public IQueryable<Product> GetProductsByParameters(Product )
        //{

        //}
    }
}
