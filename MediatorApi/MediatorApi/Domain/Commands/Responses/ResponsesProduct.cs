namespace MediatorApi.Domain.Commands.Responses
{
    public class ResponsesProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
