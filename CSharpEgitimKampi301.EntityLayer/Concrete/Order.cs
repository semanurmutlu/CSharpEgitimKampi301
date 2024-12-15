using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
       
        //-------İlişkilerimizi Kuruyoruz
        public int ProductId { get; set; } // hangi ürünü sattığımı bilmeliyim 
        public virtual Product Product { get; set; } //ProductId dediysem bu satırda olmalı! -- sipariş içerisinde ürün-ürünler imi aldım. Satış yaptığımız sırada ürüne ait bilgi olmalı 
        // Ürünün adı listede bir kez geçer ama quantity sini arttırabilirim.
        public int Quantity { get; set; }//kaç adet sattık
        public decimal UnitPrice { get; set; } // birim fiyatı
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; } //Ürün kime satıldı
        public virtual Customer Customer { get; set; } // müşterinin diğer bilgilerine ulaşmak için
    }
}
