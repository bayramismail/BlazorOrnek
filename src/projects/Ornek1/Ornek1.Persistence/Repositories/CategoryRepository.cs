using Core.Persistence.Repositories;
using Ornek1.Application.Services.Repositories;
using Ornek1.Domain.Entities;
using Ornek1.Persistence.Contexts;

namespace Ornek1.Persistence.Repositories
{
    public class CategoryRepository : EfRepositoryBase<Category, BaseDbContext>, ICategoryRepository
    {
        public CategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
