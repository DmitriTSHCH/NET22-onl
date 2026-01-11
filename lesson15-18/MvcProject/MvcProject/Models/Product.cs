using System.ComponentModel;

namespace MvcProject.Models
{
    public enum Category { electronics, furniture, cloth, other, [EditorBrowsable(EditorBrowsableState.Never)] unspecified }
    public class Product
    {
        private static int _quantity = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public Category? Category { get; set; }
        public string? Description { get; set; }

        public Product (string name, Category? category, string? description)
        {
            _quantity += 1;
            Id = _quantity;

            Name = name;

            if (category != null)
            {
                Category = category;
            }
            else
            { 
                Category = Models.Category.unspecified;
            }

            Description = description ?? "*отсутствует*";

        }
        public void Print()
        {
            Console.WriteLine($"{Id}. Название: {Name}, Категория: {Category}, Описание: {Description}");
        }
    }
}
