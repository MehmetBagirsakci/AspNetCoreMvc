using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Ürün adı boş geçilemez")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Ürün stok adedi boş geçilemez")]
        public short UnitsInStock { get; set; }

        [Required(ErrorMessage = "Ürün fiyatı boş geçilemez")]
        [Range(minimum:1,maximum:10000,ErrorMessage ="Ürün fiyatı 1 ile 10000 arasında olmalı")]
        public decimal UnitPrice { get; set; }
    }
}