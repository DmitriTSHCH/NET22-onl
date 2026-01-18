using MvcProject.Interfaces;
using MvcProject.Models;
using System.Linq;

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
        public void GetProductCount()
        {
            var productsCount = new Dictionary<Category, int>();
            string result = "Количество продуктов по категориям: \n";
            for (int i = 0; i < products.Count; i++)
            {
                if (!productsCount.ContainsKey(products[i].Category))
                {
                    productsCount.Add(products[i].Category, 1);
                }
                else 
                {
                    productsCount[products[i].Category]++;
                }
            }
            foreach (KeyValuePair<Category, int> pair in productsCount) 
            {
                result += $"{ pair.Key.ToString() } - { pair.Value.ToString() }; \n";
            }
            result += $"\nВсего - {products.Count}.\n";
            Product.resultCountNow = result;
        }
    }
}
