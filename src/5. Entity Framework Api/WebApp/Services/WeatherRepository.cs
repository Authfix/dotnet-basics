using EfApi.WebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace EfApi.WebApp.Services
{
    public interface IWeatherRepository
    {
        Task CreateAsync(Weather weatherToCreate);

        Task<IEnumerable<Weather>> GetAllAsync();
    }
    public class WeatherRepository : IWeatherRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public WeatherRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Weather weatherToCreate)
        {
            await _dbContext.Weathers.AddAsync(weatherToCreate);
        }

        public async Task<IEnumerable<Weather>> GetAllAsync()
        {
            var l = await _dbContext.Weathers.ToListAsync();

            return l;
        }
    }
}
