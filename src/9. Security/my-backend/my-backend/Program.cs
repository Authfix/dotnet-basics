using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using my_backend.Authorizations;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(a => a.AddPolicy("AngularApplication", b => b.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod()));

// Warning : singleton !!
builder.Services.AddSingleton<IAuthorizationHandler, ReadWriteAuthorizationHandler>();

builder.Services
    .AddAuthorization(o =>
    {
        o.AddPolicy("ReaderOnly", policyBuilder => 
        {
            policyBuilder.AddRequirements(new ReadWriteAuthorizationRequirement());
            policyBuilder.RequireAssertion(authorizationContext => authorizationContext.User.HasClaim("permissions", "Weathers:Read"));
        });
    })
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = "https://xxxxxxxxxxx.eu.auth0.com";
        options.Audience = "http://localhost:5216";

        options.TokenValidationParameters = new TokenValidationParameters
        {
            NameClaimType = ClaimTypes.NameIdentifier
        };
    });

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors("AngularApplication");

app.MapControllers();

app.Run();
