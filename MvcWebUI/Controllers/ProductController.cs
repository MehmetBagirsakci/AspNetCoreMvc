using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int page=1, int category=0)
        {
            //category=0 ise tüm ürünleri listele
            int pageSize = 10;
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount=(int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize=pageSize,
                CurrentCategory=category,
                CurrentPage=page
            };
            return View(model);
        }

        public ActionResult Graphic()
        {
            List<School> data = new List<School>
            {
                new School{ City="Adana", NumberOfPublicSchool=120},
                new School{ City="Adıyaman", NumberOfPublicSchool=100},
                new School{ City="Afyon", NumberOfPublicSchool=130},
                new School{ City="Ağrı", NumberOfPublicSchool=80},
                new School{ City="Amasya", NumberOfPublicSchool=69},
                new School{ City="Ankara", NumberOfPublicSchool=75},
                new School{ City="İstanbul", NumberOfPublicSchool=80},
                new School{ City="İzmir", NumberOfPublicSchool=90},
                new School{ City="İstanbul", NumberOfPublicSchool=110},
                new School{ City="Muş", NumberOfPublicSchool=120},
                new School{ City="Antalya", NumberOfPublicSchool=130},
                new School{ City="Zonguldak", NumberOfPublicSchool=100},
                new School{ City="Hatay", NumberOfPublicSchool=50}
            };
            SchoolListViewModel model = new SchoolListViewModel
            {
                Schools = data
            };
            return View(model);
        }

        //public string Session()
        //{
        //    //Session Kullanımı
        //    HttpContext.Session.SetString("city", "Ankara");
        //    HttpContext.Session.SetInt32("age", 32);

        //    string city = HttpContext.Session.GetString("city");
        //    int? age = HttpContext.Session.GetInt32("age");
        //    return city;
        //}


    }

}
