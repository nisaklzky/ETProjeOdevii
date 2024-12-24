using Et.Core.Entities;

namespace ETProjeOdevi.WebUI.Models
{
    public class ProductDetailViewModel
    {

        public Product? Product { get; set; }
        public IEnumerable<Product>? RelatedProducts { get; set; }
    }
}
