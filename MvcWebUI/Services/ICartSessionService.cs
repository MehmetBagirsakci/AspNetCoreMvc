using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Services
{
    public interface ICartSessionService
    {
        //Sessiondaki sepeti getir.
        Cart GetCart();

        //Sessiondaki sepete ürün ekle
        void SetCart(Cart cart);
    }
}
//Sessionı burada yönetmemizin sebebi projemizi test yazılabilir hale getirmek.
//Yoksa controller içerisinde de session yönetimi yapabilirdik.