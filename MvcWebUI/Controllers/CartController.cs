using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using MvcWebUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        ICartSessionService _cartSessionService;
        ICartService _cartService;
        IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            //ekledikten sonra kaybolmasın diye yeniden sessiona atıyorum.
            _cartSessionService.SetCart(cart);
            //TempData tekbir requestlik data taşır.
            //Yani gittiğiniz sayfada bir mesaj göstermek istiyorsanız onu TempDataya koyabilirsiniz
            //_Layout.cshtml de TempData null değilse ekranda göster dersiniz.
            TempData.Add("message", String.Format("Your product {0}, was successfully added to the cart!", productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }

        public ActionResult List()
        {
            //Önce sepete ulaşıyoruz.
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            //Önce sepete ulaşıyoruz
            var cart = _cartSessionService.GetCart();
            //Sepetten ürünü sildik.
            _cartService.RemoveFromCart(cart, productId);
            //Verileri tekrar sessiona yaz.
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your product, was successfully removed from the cart!"));
            return RedirectToAction("List");

        }

        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                TempData.Add("message", String.Format("Thank you {0}, your order is in process", shippingDetails.FirstName));
            }
            
            return View();
        }
    }
}
