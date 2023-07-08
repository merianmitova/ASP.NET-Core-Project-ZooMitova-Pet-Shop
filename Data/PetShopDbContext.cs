using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZooMitova_Pet_Shop.Data.Models;

namespace ZooMitova_Pet_Shop.Data
{
    public class PetShopDbContext : IdentityDbContext
    {
       
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options)
            : base(options)
        {
        }
        public DbSet<Food> Foods { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
