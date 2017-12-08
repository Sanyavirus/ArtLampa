using DomMezonin.DomainModel.DataBase;
using DomMezonin.DomainModel.Entity;
using DomMezonin.DomainModel.Repository;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;

namespace DomMezonin.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        private void AddBindings()
        {
            kernel.Bind<DbContext>().To<ArtLampaContext>().InSingletonScope();
        }

        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }


    }
}