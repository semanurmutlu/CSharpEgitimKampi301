using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }

        //-------İlişkilerimizi Kuruyoruz
        public List<Order> Orders { get; set; } // Orer la birlikte çalışacaksın diyorum haberdar ediyorum.

        // sonradan ekliyorum 
        public bool CustomerStatus { get; set; }
    }
}
