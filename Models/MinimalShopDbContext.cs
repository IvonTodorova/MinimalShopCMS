using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalShopCMS.Models
{
    public class MinimalShopDbContext : DbContext
    {
        public MinimalShopDbContext(DbContextOptions<MinimalShopDbContext> options)
              : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
