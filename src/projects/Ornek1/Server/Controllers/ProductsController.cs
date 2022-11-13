using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ornek1.Application.Features.Products.Queries.GetList;

namespace Ornek1.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : BaseController
	{
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] GetListProductQuery getListProductQuery)
		{
			
			return Ok(await Mediator.Send(getListProductQuery));

		}
	}
}
