using Core.Persistence.Repositories;
using Ornek1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Application.Services.Repositories
{
    public interface IProductRepository : IAsyncRepository<Product>, IRepository<Product>
    {

    }
}
