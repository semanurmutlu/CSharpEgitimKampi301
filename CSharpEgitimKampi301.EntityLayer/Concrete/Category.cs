using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        
        //-------İlişkilerimizi Kuruyoruz
        public List<Product> Products { get; set; } // Category tablosunu haberdar ediyorum (1 ürünün kategori bilgisine ulaşmam gerekiyor) 1 categoryde 1den fazla product olabilir...


    }

    /*
        Field-Variable-Property
     */
    /*
        int x; --> Field
     */

}
