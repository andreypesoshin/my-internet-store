using System.Collections.Generic;

namespace MyInternetStore.Domain
{
    public class Category
    {
        public int Id { get; protected set; }
        
        public string Name { get; protected set; }
        
        public virtual List<Product> Products { get; protected set; } = new List<Product>(); 

        protected Category()
        {
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}