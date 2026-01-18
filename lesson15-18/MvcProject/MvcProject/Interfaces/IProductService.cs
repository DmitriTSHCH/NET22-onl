using MvcProject.Models;

namespace MvcProject.Interfaces
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public void AddProduct(string name, string? category, string? description);
        public void DeleteProduct(int productId);
        public void RedactProduct(int productId, string? name, string? category, string? description);
        public void GetProductCount();
    }
}
