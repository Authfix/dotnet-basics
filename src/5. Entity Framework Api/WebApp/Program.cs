using EfApi.WebApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer("Server=127.0.0.1;Database=MyApp;User Id=sa;Password=P@ssw0rd;"));

var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
dbOptionsBuilder.UseSqlServer("Server=127.0.0.1;Database=MyApp;User Id=sa;Password=P@ssw0rd;");

using(var dbContext = new ApplicationDbContext(dbOptionsBuilder.Options))
{
    dbContext.Database.Migrate();
}

//using(var dbContext = new ApplicationDbContext(dbOptionsBuilder.Options))
//{
//    dbContext.Database.EnsureCreated();

//    var firstCity = new City(Guid.NewGuid(), "Paris", "75000");

//    dbContext.Cities.Add(firstCity);
//    dbContext.Cities.Add(new City(Guid.NewGuid(), "Clermont-Ferrand", "63000"));

//    dbContext.Weathers.Add(new Weather(Guid.NewGuid(), 8, firstCity));

//    dbContext.SaveChanges();

//    firstCity.Name = "Paris City Beach";

//    var ct = dbContext.ChangeTracker;
//    var we = ct.Entries<City>();

//    dbContext.SaveChanges();
//}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
