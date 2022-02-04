namespace EfApi.WebApp.Data
{
    public class City
    {
        public City(Guid id, string name, string postalCode)
        {
            Id = id;
            Name = name;
            PostalCode = postalCode;
        }

        public Guid Id { get; init; }

        public string Name { get; set; }

        public string PostalCode { get; init; }
    }
}
