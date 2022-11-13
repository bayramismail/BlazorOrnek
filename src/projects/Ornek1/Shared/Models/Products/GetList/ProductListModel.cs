using Core.Persistence.Paging;
using Ornek1.Shared.Dtos.Products.GetList;

namespace Ornek1.Shared.Models.Products.GetList
{
    public class ProductListModel : BasePageableModel
    {
        public IList<GetListProductDto> Items { get; set; }
    }
    
}
