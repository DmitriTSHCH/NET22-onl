using MvcProject.Interfaces;
using MvcProject.Models;

namespace MvcProject.Services
{
    public class ProductService : IProductService
    {
        List<Product> products = new List<Product>
            {
                new Product("Youphone18", Category.electronics, "999mp-camera, 300mah-battery, 5090rtx-gpu"),
                new Product("Шкаф", Category.furniture, "просто шкаф"),
                new Product("подлодная водка", Category.other, null)
            };

        public List<Product> GetProducts()
        {
            return products;
        }
        public void AddProduct(string name, string? category, string? description)
        {
            Category categoryEnum = Category.unspecified;
            switch (category)
            {
                case null:
                    categoryEnum = Category.unspecified;
                    break;
                case "electronics":
                    categoryEnum = Category.electronics;
                    break;
                case "furniture":
                    categoryEnum = Category.furniture;
                    break;
                case "cloth":
                    categoryEnum = Category.cloth;
                    break;
                case "other":
                    categoryEnum = Category.other;
                    break;
            }
            products.Add (new Product(name, categoryEnum, description));
        }
        public void DeleteProduct(int productId)
        {
            //через foreach не получилось
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == productId)
                {
                    products.Remove(products[i]); 
                }
            }
        }
        public void RedactProduct(int productId, string? name, string? category, string? description)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == productId)
                {
                    if (name != null)
                    {
                        products[i].Name = name;
                    }
                    if (category != null)
                    {
                        switch (category)
                        {
                            case null:
                                products[i].Category = Category.unspecified;
                                break;
                            case "electronics":
                                products[i].Category = Category.electronics;
                                break;
                            case "furniture":
                                products[i].Category = Category.furniture;
                                break;
                            case "cloth":
                                products[i].Category = Category.cloth;
                                break;
                            case "other":
                                products[i].Category = Category.other;
                                break;
                        }
                    }
                    if (description != null)
                    {
                        products[i].Description = description;
                    }
                }
            }
        }
        public int GetProductCount()
        {
            return products.Count;
        }
        public int GetProductCountByCategory(string category)
        {
            int count = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Category.ToString() == category)
                {
                    products.Remove(products[i]);
                }
            }
            return count;
        }
    }
}
