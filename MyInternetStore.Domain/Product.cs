using System.Collections.Generic;

namespace MyInternetStore.Domain
{
    public sealed class ProductProxy324234234234 : Product
    {
        // Id = ... , Name = ...
    }
    
    public class Product
    {
        public const int UsdRate = 76;

        protected Product()
        {
        }

        public Product(int id, string name, string description, decimal priceRub, decimal priceUsd, string imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            PriceRub = priceRub;
            PriceUsd = priceUsd;
            ImageUrl = imageUrl;
        }

        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public string Description { get; protected set; }

        public decimal PriceRub { get; protected set; }

        public decimal PriceUsd { get; protected set; }

        public string ImageUrl { get; protected set; }
        
        public Category Category { get; protected set; }

        public void UpdatePrice(decimal priceRub)
        {
            PriceRub = priceRub;
            PriceUsd = priceRub * UsdRate;
        }
    }
}