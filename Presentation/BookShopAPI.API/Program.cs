using BookShopAPI.Application;
using BookShopAPI.Persistence;
using BookShopAPI.API.Extensions;
using BookShopAPI.Infrastructure;
using BookShopAPI.Domain.Tokens.Options;

var builder = WebApplication.CreateBuilder(args);
var accesTokenOptions = builder.Configuration.GetSection("AccessTokenOptions").Get<AccessTokenOptions>();

builder.Services.AddControllers();
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureValidationFilter();
builder.Services.ConfigureAuthentication(accesTokenOptions);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();