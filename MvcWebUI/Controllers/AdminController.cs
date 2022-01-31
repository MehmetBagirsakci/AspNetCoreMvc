using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class AdminController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            ProductListViewModel model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public ActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }   
        
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", "Product was successfully added");
            }
            //return View(); //Bunu yazarsaksak Add.cshtmli açmaya çalışır. Hata alır. Çünkü Categorylerin veri tabanından gelmesi lazım.
            return RedirectToAction("Add"); //Add ActionResult'ını çalıştırır. Bu actionda Viewi görüntüler. Dolayısıyla categoriler veritabanında getirilir. Ekranda hata olmaz.
        }

        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product=_productService.GetById(productId),
                Categories=_categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", "Product was successfully updated");
            }
            return RedirectToAction("Update"); //Add ActionResult'ını çalıştırır. Bu actionda Viewi görüntüler. Dolayısıyla categoriler veritabanında getirilir. Ekranda hata olmaz.
        }

        public ActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            TempData.Add("message", "Product was successfully deleted");
            return RedirectToAction("Index");
        }
    }
}
