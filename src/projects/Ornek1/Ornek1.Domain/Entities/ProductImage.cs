using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Domain.Entities
{
    public class ProductImage:Entity
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public Product Product { get; set; }
        public ProductImage()
        {
            Product= new Product();
        }

        public ProductImage(int id,int productId, string imageUrl):base (id)
        {
            ProductId = productId;
            ImageUrl = imageUrl;
          
        }

        public ProductImage(int id, int productId, string imageUrl,Product product):this(id, productId, imageUrl)
        {
            Product = product;
        }
    }
}
