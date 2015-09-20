using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using Models.SportStoreModels;

namespace MVC5TestRepo.Models.SportStoreModels
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("SportStoreDb")
        {
            Database.SetInitializer<ProductDbContext>( new ProductDbInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}