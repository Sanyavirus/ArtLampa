using DomMezonin.DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Services
{
    interface IService<TEntity> where TEntity : EntityBase
    {
        TEntity GetEntity(long id);


    }
}
