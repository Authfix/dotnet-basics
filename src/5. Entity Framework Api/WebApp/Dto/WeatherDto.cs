namespace EfApi.WebApp.Dto
{
    public class WeatherDto
    {
        public Guid Id { get; set; }

        public int Value { get; set; }

        public Guid CityId { get; set; }

        public string CityName { get; set; }
    }
}
