using EfApi.WebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public WeatherController(ILogger<WeatherController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet()]
        public async Task<IEnumerable<Weather>> Get()
        {
            var w = await _dbContext.Weathers.Include(w => w.City).ToListAsync();

            return w;
        }
    }
}