using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStok { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        
        //-------İlişkilerimizi Kuruyoruz
        public int CategoryId { get; set; }//her ürünün 1 kategorisi olmalı
        public virtual Category Category { get; set; } //1 ürünün kategori bilgisine ulaşmam gerekiyor - kategori nin tüm bilgilerine erişmem içinde category türünde category propertysi oluşturmalıyım
        public List<Order> Orders { get; set; } //(ürün tablosu listeye dönecek) 1-m ilişki için her bir ürün siparişler olarak listelenebilmeli

    }
}
