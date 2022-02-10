using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using MvcWebUI.Utilities.PopupBox.SweetAlert2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class SweetAlert2Controller : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;
        public SweetAlert2Controller(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }


        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData["sweetAlertIsSuccess"] = "True";
            }
            else
            {
                TempData["sweetAlertIsSuccess"] = "False";
            }
            return RedirectToAction(nameof(Create));
        }
    }
}
