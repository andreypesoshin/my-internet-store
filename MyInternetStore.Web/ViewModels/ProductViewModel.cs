namespace MyInternetStore.Web.ViewModels
{
    // POCO = Plain Old C# (CLR) Object
    
    public class ProductViewModel
    {
        public string Name { get; set; }
        
        public string ImageUrl { get; set; }
        
        public decimal Price { get; set; }
    }
}