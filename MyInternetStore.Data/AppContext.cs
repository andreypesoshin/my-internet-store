using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyInternetStore.Domain;

namespace MyInternetStore.Data
{
    public class MyAppContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public MyAppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory);
        }
        
        // public static readonly ILoggerFactory ConsoleLoggerFactory
        //     = LoggerFactory.Create(builder => { builder.AddConsole(); });

    }
}