using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Domain.Entities
{
    public class Product : Entity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public Product()
        {
            Category = new Category();
            ProductImages= new List<ProductImage>();
        }
        public Product(int id, int categoryId, string name, string description, decimal price, decimal discount) : base(id)
        {
            CategoryId = categoryId;
            Name = name;
            Description = description;
            Price = price;
            Discount = discount;

        }

        public Product(int id, int categoryId, string name, string description, decimal price, decimal discount, Category category) : this(id, categoryId, name, description, price, discount)
        {
            Category = category;
        }
    }
}
