using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyInternetStore.Domain;

namespace MyInternetStore.Data
{
    public class MyAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public MyAppContext(DbContextOptions options) : base(options)
        {
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