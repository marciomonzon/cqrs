using MediatorApi.Domain.Commands.Requests;
using MediatorApi.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public async Task<ResponsesProduct> Cadastro([FromServices] IMediator mediator, [FromBody] RequestsProduct request)
        {
            return await mediator.Send(request);
        }
    }
}
