using MediatorApi.Domain.Commands.Responses;
using MediatR;

namespace MediatorApi.Domain.Commands.Requests
{
    public class RequestsProduct : IRequest<ResponsesProduct>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
