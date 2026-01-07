namespace MvcProject.Models
{
    public class Storage
    {
        public string Id { get; set; }
        public List<Product>? Products { get; set; }

        public Storage(string id)
        {
            Id = id;
            Products = new List<Product>();
        }
        public Storage(string id, List<Product>? products)
        {
            Id = id;
            Products = products;
        }
        public void AddProduct(Product product)
        { 
            Products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
        public void PrintListProduct()
        {
            if (Products == null)
            {
                Console.WriteLine("Склад пуст");
            }
            else
            {
                foreach (Product product in Products)
                {
                    product.Print();
                }
            }
        }
    }
}
