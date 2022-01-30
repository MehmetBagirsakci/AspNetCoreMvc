using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using MvcWebUI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
           Cart cartToCheck= _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck == null)
            {
                //sepet ilk kez oluşturuluyor. Sepete boş bir nesne ekledik.
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
//****** ÇOK ÖNEMLİ ************
//Sessionlar default olarak, Controllerda çalışır. Ama burası bir controller değil.
//Burada session'ı kullanmak istiyorsak, Session'ın base'i olan IHttpContextAccessor
//interfaceini Dependency injection ile almalıyız.