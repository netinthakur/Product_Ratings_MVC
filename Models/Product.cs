using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Ratings_MVC.Models
{
    //A product
    public class Product
    {
        //Product id
        public int Id { get; set; }

        //Product name 
        public string Name { get; set; }

        //Product price.
        public decimal Price { get; set; }
    }
}
