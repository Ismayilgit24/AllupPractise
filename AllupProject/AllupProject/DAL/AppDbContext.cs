using AllupProject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AllupProject.DAL
{
    public class AppDbContext:DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slide> Slides { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }

    }
}
