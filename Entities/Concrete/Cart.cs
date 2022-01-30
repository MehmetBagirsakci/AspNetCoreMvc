using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
            //Eğer bunun yazmasa idik ilk etapta hiç bir ürün yokken
            //ObjectNullReferance hatası alırdık.
        }
        public List<CartLine> CartLines { get; set; }
        public Decimal Total
        {
            get
            {
                return CartLines.Sum(c => c.Product.UnitPrice * c.Quantity);
            }
        }
    }
}
//Sepet