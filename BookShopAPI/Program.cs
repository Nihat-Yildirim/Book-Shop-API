using BookShopAPI.Extensions;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Core.DepedencyResolvers;
using Core.Extensions;
using Core.Utilities.IOC;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using Entities.MapperProfiles;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();


builder.Services.AddControllers();
builder.Services.AddDependencyResolvers(new ICoreModule[] { new CoreModule()});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureAuthentication(tokenOptions);
builder.Services.ConfigureAutoMapper();
builder.Host.ConfigureAutofacProviderFactory();
builder.Host.ConfigureLogger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddApiUserHandlingMiddleware();

app.AddGlobalExceptionHandler();

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();