using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Ratings_MVC.Models
{
    //A rating 
    public class Rating
    {
        //Rating id
        public int Id { get; set; }

        //Customer id
        public int CustomerId { get; set; }

        //product id
        public int ProductId { get; set; }


        //Customer reference
        public Customer Customer { get; set; }

        //Product reference

        public Product Product { get; set; }

        //Rating value from the customer out of 5

        [Range(0, 5, ErrorMessage = "Input for {0} must in the range {1} - {2}.")]
        public int RatingValue { get; set; }

        //Comments of the customer.
        public string Comment { get; set; }



    }
}
