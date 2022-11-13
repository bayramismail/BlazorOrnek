using Core.Persistence.Repositories;
using Ornek1.Domain.Entities;

namespace Ornek1.Application.Services.Repositories
{
    public interface ICategoryRepository : IAsyncRepository<Category>, IRepository<Category>
    {

    }
}
