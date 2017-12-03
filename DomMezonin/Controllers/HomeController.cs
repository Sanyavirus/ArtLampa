using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomMezonin.DomainModel.Entity;
using DomMezonin.DomainModel.Repository;

namespace DomMezonin.Controllers
{
    public class HomeController : Controller
    {
        private RepositoryContext repositoryContext;
        private RepositoryBase<Product> productRepository;
        private RepositoryBase<Category> categoryRepository;
        private RepositoryBase<Image> imagesRepository;

        public HomeController()
        {
            repositoryContext = new RepositoryContext();
            productRepository = new ProductRepository(repositoryContext);
            categoryRepository = new CategoryRepository(repositoryContext);
            imagesRepository = new ImagesRepository(repositoryContext);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Category()
        {
            return View();
        }

        public JsonResult GetCategory()
        {
            IDictionary<string, Category> categories = categoryRepository.GetEntities().ToDictionary(p => p.Id.ToString(), v => v);
            return Json(categories, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}