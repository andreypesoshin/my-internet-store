using Microsoft.EntityFrameworkCore;
using MyInternetStore.Domain;

namespace MyInternetStore.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext()
        {
        }
        
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}