namespace MediatorApi.Domain.Entities
{
    public class Product
    {
        public Product(string name, decimal value)
        {
            Id = Guid.NewGuid();
            Name = name;
            Value = value;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Value { get; private set; }


    }
}
