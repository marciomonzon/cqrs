using MediatorApi.Domain.Commands.Requests;
using MediatorApi.Domain.Commands.Responses;

namespace MediatorApi.Domain.Handlers
{
    public interface ICadastroProductHandler
    {
        ResponsesProduct Handle(RequestsProduct request);
    }
}
