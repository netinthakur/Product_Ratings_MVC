using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Ratings_MVC.Models
{
    //A customer.
    public class Customer
    {
        //Customer id
        public int Id { get; set; }

        //Customer name.
        public string Name { get; set; }

        //Customer email.
        public string Email { get; set; }
    }
}
