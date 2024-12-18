using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProducName { get; set; }
        public int ProductStock { get; set; }

        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public  List<Order>Orders  { get; set; }

        //[NotMapped]
       // public string CategoryName { get; set; }




    }
}
