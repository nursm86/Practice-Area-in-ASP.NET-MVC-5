using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Area_Practice.Areas.Product.Data;

namespace Area_Practice.Areas.Product.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository proRepo = new ProductRepository();
        // GET: Product/Product
        public ActionResult ProductList()
        {
            return View(proRepo.GetAll());
        }

        public ActionResult ProductAddEdit()
        {
            return View();
        }
    }
}