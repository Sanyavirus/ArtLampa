using DomMezonin.DomainModel.Entity;
using DomMezonin.DomainModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace DomMezonin.Controllers
{
    public class ProductController : Controller
    {
        RepositoryBase<Product> prodRepository;
        public ProductController(RepositoryBase<Product> prodRepository)
        {
            this.prodRepository = prodRepository;
        }

        public JsonResult GetProduct()
        {
            var res = prodRepository.GetEntities();
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProductById(int id)
        {
            var res = prodRepository.GetEntity(id);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}
