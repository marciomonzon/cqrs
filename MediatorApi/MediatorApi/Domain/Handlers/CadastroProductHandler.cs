using MediatorApi.Domain.Commands.Requests;
using MediatorApi.Domain.Commands.Responses;
using MediatR;

namespace MediatorApi.Domain.Handlers
{
    public class CadastroProductHandler : IRequestHandler<RequestsProduct, ResponsesProduct>
    {
        public Task<ResponsesProduct> Handle(RequestsProduct request, CancellationToken cancellationToken)
        {
            var resultado = new ResponsesProduct
            {
                Id = Guid.NewGuid(),
                Name = "Xpto",
                Value = 40000,
                Date = DateTime.Now
            };

            return Task.FromResult(resultado);
        }
    }
}
