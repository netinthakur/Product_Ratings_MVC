using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product_Ratings_MVC.Models;

namespace Product_Ratings_MVC.Models
{
    //Connects the database with the model layer
    public class Product_Ratings_MVCDataContext : DbContext
    {
        public Product_Ratings_MVCDataContext (DbContextOptions<Product_Ratings_MVCDataContext> options)
            : base(options)
        {
        }

        public DbSet<Product_Ratings_MVC.Models.Customer> Customer { get; set; }

        public DbSet<Product_Ratings_MVC.Models.Product> Product { get; set; }

        public DbSet<Product_Ratings_MVC.Models.Rating> Rating { get; set; }
    }
}
