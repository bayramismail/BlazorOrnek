using Core.Persistence.Repositories;
using Ornek1.Application.Services.Repositories;
using Ornek1.Domain.Entities;
using Ornek1.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Persistence.Repositories
{
    public class ProductRepository : EfRepositoryBase<Product, BaseDbContext>, IProductRepository
    {
        public ProductRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
