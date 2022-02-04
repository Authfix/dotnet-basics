namespace EfApi.WebApp.Data
{
    public class Weather
    {
        public Weather(Guid id, int value, City city): this(id, value, city.Id)
        {
            City = city;
        }

        public Weather(Guid id, int value, Guid cityId)
        {
            Id = id;
            Value = value;
            CityId = cityId;
        }

        public int Value { get; init; }

        public Guid Id { get; init; }

        public Guid CityId { get; init; }

        public City? City { get; init; }
    }
}
